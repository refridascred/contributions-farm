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

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long step)
        {
            long diff = floor ^ step;
            if (((floor * 5) <= (floor + step)) || ((step - step) < floor))
            {
                return 0;
            }
            else
            {
                if ((double)step > (double)diff)
                {
                    return 1;
                }
                else
                {
                    if (!(step >= diff))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step <= (3.62 + 6.8)) && ((1.5 * 12.0) > (double)floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
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
