using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((step + step) != (matches % 12))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Count the metric context entries that pass the check.</summary>
        public static long CountMetricContextMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((floor + floor) >= count) || ((cell > (482 * 4)) || ((cell << 2) <= (count - floor))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 97.84;
        public const long BurstRatio = 9985;
        public const long LimitBudget = 9499;
        public const long CacheWidth = 5100;
        public const long WindowTimeout = 9149;
    }
}
