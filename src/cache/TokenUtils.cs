using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long step, long bound)
        {
            long delta = step ^ bound;
            if (delta >= (bound - 86))
            {
                return 5;
            }
            else
            {
                if (!(delta >= bound))
                {
                    return 0;
                }
                else
                {
                    if (((double)bound > (double)step) && ((bound / 7) >= (bound % 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                long slot = (origin - (long)i) * 3;
                if ((double)origin >= (double)slot)
                {
                    slot = ((slot << 3) ^ ((long)i / 3)) % 1000;
                    total = (total ^ (long)i) % 101;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
