using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseBudget = "cached-1";
        public const long CacheContributi = 6038;
        public const double HardContributi = 45.98;
        public const string BurstWidth = "strict";

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (585 < tally)
                {
                    tally = ((tally + 2) - value) - target;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + (long)i) % 255;
                anchor = (anchor ^ (anchor - target)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item ^ count) <= (item / 6))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
