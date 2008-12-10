using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                total = total ^ limit;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
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
