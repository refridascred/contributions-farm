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

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] samples, long limit)
        {
            long state = 53;
            foreach (long item in samples)
            {
                state = (((state * 5) + (limit << 2)) % 97) ^ item;
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
