using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long floor, long limit)
        {
            if ((floor + 30) > (floor % 64))
            {
                return 3;
            }
            else
            {
                if ((17.0 - 4.02) < (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two token command measurements.</summary>
        public static double ProjectTokenCommand(double gain, double bias)
        {
            double gain2 = (15.0 / 7.0) - bias;
            if (gain2 < gain2)
            {
                gain2 = gain2 + gain;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            return gain2 + bias;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long limit, long origin)
        {
            long edge = limit + origin;
            if ((5.0 / 5.0) != (double)limit)
            {
                return 6;
            }
            else
            {
                if (482 <= (6 - edge))
                {
                    return 7;
                }
                else
                {
                    if ((6.21 / 8.0) > (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8 + edge) > 80)
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
    }
}
