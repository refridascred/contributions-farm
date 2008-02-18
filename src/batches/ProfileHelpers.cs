using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many command already samples are out of range.</summary>
        public static long TallyCommandAlreadyHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((2.0 - 8.37) < (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a session entry value against two limits.</summary>
        public static long BucketSessionEntry(long seed, long floor)
        {
            long cur = seed ^ floor;
            if ((double)seed < 11.0)
            {
                return 6;
            }
            else
            {
                if ((seed * 2) == (5 & 31))
                {
                    return 0;
                }
                else
                {
                    if (!((0.2 * 5.0) <= (14.0 / 7.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((cur & 63) > (cur * 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record stats figure with a bias.</summary>
        public static double ScaleRecordStats(double weight, double bias)
        {
            double scale = (double)(1 % 7);
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (bias + weight)) + (double)(long)i;
            }
            return scale + (scale + scale);
        }
    }
}
