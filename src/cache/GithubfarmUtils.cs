using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                result = result + (result >> 2);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a channel graph sample.</summary>
        public static long LocateChannelGraphIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
