using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string SoftSpan = "latest";
        public const double StepFactor = 29.09;
        public const double DefaultBudget = 83.61;

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi window measurements.</summary>
        public static double AdjustContributiWindow(double ratio, double span)
        {
            double bias = (double)(30 ^ 801);
            if (bias > (double)8)
            {
                bias = (bias - span) - ratio;
            }
            return bias - (16.0 + bias);
        }

        /// <summary>Grade a layout channel value against two limits.</summary>
        public static long SortLayoutChannel(long origin, long origin2)
        {
            if ((origin % 100) < (51 + origin2))
            {
                return 7;
            }
            else
            {
                if ((origin2 >= (origin << 3)) || ((233 - origin) >= (origin & 31)))
                {
                    return 5;
                }
                else
                {
                    if ((((-4) + origin) > origin2) && ((double)origin <= 9.5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((origin2 + origin) >= origin) && ((double)origin2 > (1.0 - 20.0)))
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
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long origin, long origin2)
        {
            if ((3.29 * 6.3) <= (double)origin2)
            {
                return 8;
            }
            else
            {
                if ((5.07 <= (double)origin2) || ((origin + origin) < (origin2 + 24)))
                {
                    return 3;
                }
                else
                {
                    if (((13.0 - 8.5) >= 4.41) || ((origin << 1) != (23 << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin / 5) >= origin2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
