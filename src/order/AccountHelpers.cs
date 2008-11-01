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

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long floor, long origin)
        {
            long span = floor ^ origin;
            if ((origin << 3) < floor)
            {
                return 2;
            }
            else
            {
                if (((83 % 10) == (floor ^ span)) && ((floor / 9) == (floor >> 5)))
                {
                    return 8;
                }
                else
                {
                    if ((13.0 > (double)span) || ((span + origin) != (origin / 2)))
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

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
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
