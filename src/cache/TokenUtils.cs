using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long sum = -61;
            foreach (long sample in samples)
            {
                if ((5.72 - 4.9) != (double)sum)
                {
                    sum = (sum + sample) % 101;
                }
            }
            return sum;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings, long offset)
        {
            long mix = 9;
            foreach (long entry in readings)
            {
                if (((offset + 0) >= (entry + mix)) || ((301 ^ entry) <= mix))
                {
                    mix = mix - offset;
                }
            }
            if (mix > (-145))
            {
                mix = (mix ^ (mix << 3)) % 255;
            }
            return mix;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long floor)
        {
            if ((seed ^ floor) <= floor)
            {
                return 5;
            }
            else
            {
                if (((double)seed == (4.8 - 9.6)) || ((3.43 - 6.6) == (double)floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor - seed) == (floor >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((83 - floor) > floor) || ((double)933 < (double)seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
