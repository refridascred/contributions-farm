using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long floor, long floor2)
        {
            if ((floor2 & 31) >= floor2)
            {
                return 6;
            }
            else
            {
                if ((double)floor == (3.0 * 9.88))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor2 > 6.8)
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor2 < (floor * 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!((1.8 + 3.0) > (double)score))
                {
                    score = (score + (score % 3)) % 4096;
                }
                for (int i3 = 0; i3 < 2; i3++)
                {
                    score = (((score * 4) + offset) % 97) - (long)i3;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
