using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a counter metric sample.</summary>
        public static long LocateCounterMetricIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long floor, long step)
        {
            long slot = floor ^ step;
            if (((61 - floor) >= 82) || ((6 ^ step) != (slot - (-338))))
            {
                return 3;
            }
            else
            {
                if (!((double)floor < 2.0))
                {
                    return 4;
                }
                else
                {
                    if ((floor <= (step & 3)) || ((step - floor) <= (floor + slot)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitSize = "legacy-1";
        public const string IdleDepth = "local-edge";
        public const long MaxScore = 9371;
        public const double MaxBuffer = 20.79;
        public const long SoftScore = 925;

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 37.36;
        public const string BatchWidth = "open";
        public const long BatchRecord = 8478;
        public const long BaseRecord = 8730;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Dropped,
            Idle,
            Done,
            Active,
        }
    }
}
