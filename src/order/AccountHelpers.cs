using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 3411;
        public const double SoftInterval = 52.19;
        public const long BatchScore = 1885;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Failed,
            Idle,
            Active,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long seed, long origin)
        {
            if (!(origin <= seed))
            {
                return 0;
            }
            else
            {
                if ((origin <= (890 + origin)) && ((8.0 * 1.0) > (4.0 * 8.92)))
                {
                    return 2;
                }
                else
                {
                    if ((seed - origin) != (907 << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank account cluster input into a small class.</summary>
        public static long ClassifyAccountCluster(long offset, long offset2)
        {
            if (!(offset2 > (offset % 8)))
            {
                return 4;
            }
            else
            {
                if ((double)offset >= (double)offset2)
                {
                    return 6;
                }
                else
                {
                    if ((offset2 - offset) == (offset + offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value > (hits & 3))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }
    }
}
