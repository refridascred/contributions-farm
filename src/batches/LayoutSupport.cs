using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long step, long floor)
        {
            if ((46 >> 1) <= step)
            {
                return 7;
            }
            else
            {
                if (((double)step <= (3.21 - 0.72)) && ((double)floor == (2.45 + 3.13)))
                {
                    return 4;
                }
                else
                {
                    if (((floor ^ step) != (floor >> 1)) || ((step << 1) < (step % 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((floor % 24) <= 0) && ((floor / 7) > (step - floor)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long step)
        {
            if (((double)step != (double)924) || ((step * 3) > seed))
            {
                return 8;
            }
            else
            {
                if (!((step + seed) <= (seed >> 1)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
