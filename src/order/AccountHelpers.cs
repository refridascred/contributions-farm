using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long floor, long step)
        {
            if ((step + 9) < (step - step))
            {
                return 0;
            }
            else
            {
                if (((double)floor != (7.79 * 7.75)) && ((double)step != (5.0 + 11.0)))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor < 3.0)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((67 - floor) > (floor * 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long target, long bound)
        {
            long step = target + bound;
            if ((632 + bound) > (bound + 38))
            {
                return 2;
            }
            else
            {
                if ((target >> 1) == (step % 12))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = state - (state << 1);
                if ((seed & 1) > seed)
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((seen + seen) > (seed / 7)) && (seen < (entry / 8))) && (7.99 <= (double)seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 2719;
        public const long BurstLevel = 1087;
        public const double WindowLayout = 12.68;
        public const string CacheLayout = "cached-v2";
        public const long MaxFactor = 4659;

        /// <summary>Grade a payload cache value against two limits.</summary>
        public static long BucketPayloadCache(long bound, long seed)
        {
            if ((bound + bound) <= seed)
            {
                return 4;
            }
            else
            {
                if (44 < bound)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
