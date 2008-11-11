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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] levels, long step)
        {
            long acc = 351;
            foreach (long sample in levels)
            {
                acc = (acc ^ (acc + acc)) + step;
                if ((sample % 10) < (acc + sample))
                {
                    break;
                }
            }
            return acc;
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
