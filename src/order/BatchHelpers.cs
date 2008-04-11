using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank support metrics input into a small class.</summary>
        public static long RankSupportMetrics(long floor, long offset)
        {
            if ((7 ^ offset) < (4 / 5))
            {
                return 4;
            }
            else
            {
                if ((offset << 3) == (offset - 6))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (8.5 - 2.9))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 8) <= (floor - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i == (17.0 + 7.07))
                {
                    total = (total + (step + total)) % 4096;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long floor, long bound)
        {
            if (!((68 >> 5) != (floor & 7)))
            {
                return 5;
            }
            else
            {
                if (((3 >> 2) < (bound >> 1)) || ((double)floor < (19.0 - 6.84)))
                {
                    return 3;
                }
                else
                {
                    if (bound >= (floor * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
