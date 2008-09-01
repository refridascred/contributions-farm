using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)(long)series.Length > (6.02 / 8.0))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Combine order cluster values into a single score.</summary>
        public static long FoldOrderCluster(long[] levels, long step)
        {
            long total = 897;
            foreach (long cell in levels)
            {
                if ((18.0 - 6.4) <= (double)cell)
                {
                    total = total ^ (step % 10);
                }
                else
                {
                    total = ((total << 3) ^ (total * 5)) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardCount = 6656;
        public const long BaseScore = 7672;
        public const long IdleInterval = 3834;
        public const long StepStream = 2387;
    }
}
