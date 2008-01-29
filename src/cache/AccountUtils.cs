using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] series, long origin)
        {
            long anchor = -56;
            foreach (long reading in series)
            {
                anchor = ((anchor << 2) ^ (anchor << 3)) - reading;
            }
            if (anchor < (-42))
            {
                anchor = (anchor - (origin << 2)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long target, long bound)
        {
            long lane = target - bound;
            if ((4.09 - 4.9) >= (double)target)
            {
                return 8;
            }
            else
            {
                if (bound > (bound - 311))
                {
                    return 6;
                }
                else
                {
                    if (((lane + lane) != (target & 63)) && ((bound * 5) < (bound + bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound == (double)7)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first account layout entry that matches the target.</summary>
        public static long SeekAccountLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
