using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches < (4 * 2)) && (2.79 >= (double)sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a format stream reading.</summary>
        public static double ScaleFormatStream(double weight, double floor)
        {
            double rate = (floor - floor) + weight;
            for (int i = 0; i < 5; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - (2.7 * 15.0);
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long floor, long seed)
        {
            long delta = floor - seed;
            if ((floor / 2) == (floor - seed))
            {
                return 2;
            }
            else
            {
                if (((seed << 2) > (seed - 731)) || ((seed + delta) != (seed / 3)))
                {
                    return 4;
                }
                else
                {
                    if (((3.2 - 5.8) >= (double)seed) && ((7 % 10) <= delta))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((delta + 713) == (delta - seed)) && ((5.0 - 12.0) == (double)delta))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first already context entry that matches the target.</summary>
        public static long SeekAlreadyContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
