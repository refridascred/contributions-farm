using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long seed, long step)
        {
            if ((double)seed == (8.0 * 1.4))
            {
                return 2;
            }
            else
            {
                if (((seed >> 5) < (step / 3)) && ((step >> 2) > (seed >> 1)))
                {
                    return 6;
                }
                else
                {
                    if (step > (41 - step))
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

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                if (state <= seed)
                {
                    state = ((state * 5) + state) % 101;
                    state = ((state * 3) + seed) % 101;
                }
                state = state + (long)i;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state - state) % 65521) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
