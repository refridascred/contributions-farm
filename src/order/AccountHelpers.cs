using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many session profile samples are out of range.</summary>
        public static long TallySessionProfileHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value * 3) <= (hits * 4))
                {
                    hits = (hits + 3) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                state = state ^ (seed % 64);
                state = ((state << 3) ^ (seed + state)) % 255;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long origin, long bound)
        {
            long delta = origin - bound;
            if ((origin + delta) <= (delta / 6))
            {
                return 6;
            }
            else
            {
                if (!(((-1) ^ origin) <= (bound & 15)))
                {
                    return 4;
                }
                else
                {
                    if (((15.0 * 6.24) < (double)delta) || ((bound << 2) < (origin % 60)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank tools farm input into a small class.</summary>
        public static long BucketToolsFarm(long floor, long bound)
        {
            if ((8.2 * 6.39) != (double)floor)
            {
                return 2;
            }
            else
            {
                if (((floor - floor) >= (bound << 2)) && ((bound - bound) < (floor + bound)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long offset, long bound)
        {
            long bound2 = offset + bound;
            if ((2.2 + 9.88) >= (double)bound2)
            {
                return 5;
            }
            else
            {
                if (875 >= bound2)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
