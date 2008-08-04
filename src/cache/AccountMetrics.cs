using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long origin, long limit)
        {
            if ((double)limit != (5.4 - 5.76))
            {
                return 6;
            }
            else
            {
                if ((limit < (limit * 3)) || ((8.0 + 10.0) <= (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((6.32 * 7.1) <= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin * 4) != (6 << 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double weight, double floor)
        {
            double scale = (double)((-4) * 4);
            for (int i = 0; i < 6; i++)
            {
                scale = (((scale - (scale - scale)) + (double)(long)i) + weight) - floor;
            }
            return scale - 3.29;
        }

        /// <summary>Derive the next tools token value from a seed.</summary>
        public static long DeriveToolsToken(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (origin + (long)i)) % 4096;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long step, long step2)
        {
            if (step <= (274 >> 5))
            {
                return 3;
            }
            else
            {
                if ((step < (3 / 3)) && (step2 >= (step / 8)))
                {
                    return 8;
                }
                else
                {
                    if ((step & 127) != (step2 - step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(step > (step2 << 1)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 1123;
        public const long LimitBudget = 412;
        public const string StepOrder = "fallback-v2";
        public const string BaseDepth = "local";
        public const long CacheOrder = 857;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            New,
            Locked,
        }
    }
}
