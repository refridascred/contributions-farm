using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((seed >> 5) < seed) && ((hits * 2) >= (4 + hits)))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload schema value against two limits.</summary>
        public static long RankPayloadSchema(long origin, long step)
        {
            long cur = origin - step;
            if (step <= (step - cur))
            {
                return 5;
            }
            else
            {
                if ((42 >> 5) > (step + cur))
                {
                    return 6;
                }
                else
                {
                    if (!((cur & 63) < (cur - 9)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(cur < 47))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "legacy";
        public const long HardSpan = 6760;
        public const long HardStats = 8015;
        public const long WindowTimeout = 8345;
        public const string WindowStats = "standard-edge";
    }
}
