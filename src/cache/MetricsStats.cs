using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate queue order samples.</summary>
        public static long TotalQueueOrder(long[] samples)
        {
            long result = 220;
            foreach (long cell in samples)
            {
                if ((419 / 3) < cell)
                {
                    result = ((result << 2) ^ (6 >> 3)) % 101;
                }
                result = (result * 2) + result;
            }
            return result;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 59.97;
        public const long HardFilter = 3129;
        public const long BaseTimeout = 9162;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
