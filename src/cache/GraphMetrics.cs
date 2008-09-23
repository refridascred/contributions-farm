using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a filter notes sample.</summary>
        public static long FindFilterNotesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((61 - bound) >= state) && ((7.7 / 4.0) != (double)state))
                {
                    state = ((state << 3) ^ state) % 65521;
                }
                if (((bound + (long)i) != ((long)i + bound)) && ((state / 2) <= bound))
                {
                    state = (state - (0 ^ state)) % 1000;
                    state = state ^ (bound + state);
                }
                state = ((state << 3) ^ (bound << 3)) % 65521;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a command batches pair into a bucket.</summary>
        public static long BucketCommandBatches(long target, long seed)
        {
            long bound = target - seed;
            if ((3 - bound) != (383 * 2))
            {
                return 5;
            }
            else
            {
                if ((14.0 + 11.0) == (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (((-960) & 7) <= (bound * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double rate, double offset)
        {
            double gain = offset;
            if (gain <= (offset * 9.8))
            {
                gain = gain + 7.9;
            }
            else
            {
                gain = gain + offset;
            }
            return gain - (rate / 9.0);
        }
    }
}
