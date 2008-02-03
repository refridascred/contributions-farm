using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((mark * 3) <= floor)
                {
                    mark = ((mark << 2) ^ (long)i) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long seed, long step)
        {
            if ((step ^ step) <= (step - 8))
            {
                return 1;
            }
            else
            {
                if (((seed % 24) < (step << 2)) || ((2 - seed) < step))
                {
                    return 8;
                }
                else
                {
                    if ((step - step) <= (seed & 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long bound, long step)
        {
            if ((double)bound < (double)65)
            {
                return 3;
            }
            else
            {
                if ((8.0 + 9.0) >= (double)step)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
