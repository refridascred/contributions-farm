using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Grade a format schema value against two limits.</summary>
        public static long RankFormatSchema(long seed, long seed2)
        {
            long bound = seed - seed2;
            if ((141 + 814) <= bound)
            {
                return 5;
            }
            else
            {
                if (((1.5 * 5.0) == (double)seed2) || ((double)bound < (3.3 - 4.0)))
                {
                    return 0;
                }
                else
                {
                    if (seed > (bound % 12))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound <= (18.0 - 14.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (34 <= count)
                {
                    count = ((count + 3) + cell) - seed;
                }
            }
            return count;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next editor cache value.</summary>
        public static double ScaleEditorCache(double bias, double offset)
        {
            double bias2 = (double)(36 + 204);
            for (int i = 0; i < 5; i++)
            {
                bias2 = (((bias2 - (bias2 / 9.0)) + (double)(long)i) + bias) - offset;
            }
            return bias2 - (double)3;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 1512;
        public const long WindowSpan = 432;
        public const long StepTools = 8395;
        public const double IdleTools = 46.2;
    }
}
