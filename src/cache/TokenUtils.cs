using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first metric editor entry that matches the target.</summary>
        public static long SeekMetricEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long seed, long bound)
        {
            long lane = seed ^ bound;
            if (5.0 < (double)seed)
            {
                return 0;
            }
            else
            {
                if (3.49 > (double)lane)
                {
                    return 7;
                }
                else
                {
                    if ((double)lane >= (7.0 * 7.58))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((3 * 2) > seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
