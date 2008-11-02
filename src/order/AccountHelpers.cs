using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double bias, double span)
        {
            double scale = (double)(-8) * 2.21;
            return ((scale - scale) + bias) + span;
        }

        /// <summary>Look up the position of a stream cluster sample.</summary>
        public static long LookupStreamClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long floor, long origin)
        {
            if ((4.3 >= (double)floor) || ((847 - origin) < (floor + floor)))
            {
                return 2;
            }
            else
            {
                if ((origin + origin) <= origin)
                {
                    return 1;
                }
                else
                {
                    if (!((double)origin > (2.6 + 6.5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor << 3) == (0 >> 4)) && (origin > floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next order queue value.</summary>
        public static double AdjustOrderQueue(double rate, double bias)
        {
            double scale = rate;
            if (scale >= (4.0 / 8.0))
            {
                scale = scale - (rate / 3.0);
            }
            else
            {
                scale = scale + (bias + bias);
            }
            return scale - (rate - scale);
        }
    }
}
