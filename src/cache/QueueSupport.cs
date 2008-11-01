using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long limit, long step)
        {
            if ((step << 1) <= (step % 10))
            {
                return 1;
            }
            else
            {
                if (((step / 6) < (step / 9)) && ((step - limit) <= limit))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (((state << 3) ^ bound) % 255) - (long)i2;
                }
                state = (state + (bound ^ state)) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
