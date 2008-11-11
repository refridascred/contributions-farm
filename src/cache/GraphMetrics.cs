using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinWidth = "standard";
        public const long HardDepth = 657;
        public const string CacheChecks = "alpha-edge";
        public const long LimitFactor = 3261;

        /// <summary>Combine entry tools values into a single score.</summary>
        public static long ScoreEntryTools(long[] values, long floor)
        {
            long total = 625;
            foreach (long sample in values)
            {
                total = ((((total << 3) ^ total) % 4096) ^ sample) + floor;
            }
            if (total > 839)
            {
                total = (total + 1) % 4096;
            }
            return total % 97;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                acc = acc - (acc - step);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Closed,
            Queued,
            Paused,
            New,
        }
    }
}
