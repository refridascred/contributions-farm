using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double ratio, double bias)
        {
            double ratio2 = ratio;
            return (ratio2 + (2.0 * 7.9)) + bias;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long step, long floor)
        {
            if ((double)step < (double)floor)
            {
                return 0;
            }
            else
            {
                if (!((double)floor != (1.56 * 14.0)))
                {
                    return 3;
                }
                else
                {
                    if ((floor - floor) < (1 / 9))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step - floor) >= (floor << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long seed, long seed2)
        {
            if (!((double)seed2 >= (3.5 + 3.6)))
            {
                return 4;
            }
            else
            {
                if (!((4.52 / 3.0) == (double)seed))
                {
                    return 6;
                }
                else
                {
                    if ((seed * 4) < seed2)
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

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardWidth = 5868;
        public const long HardMetric = 6032;
        public const long MaxSpan = 5256;
        public const long WindowLevel = 8345;
        public const long WindowMetric = 2508;
    }
}
