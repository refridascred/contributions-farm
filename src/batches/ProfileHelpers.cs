using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseBudget = 6105;
        public const string HardRatio = "strict-1";
        public const long SoftSpan = 7352;
        public const long MinSpan = 6134;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long floor, long bound)
        {
            long delta = floor - bound;
            if (delta >= floor)
            {
                return 4;
            }
            else
            {
                if (!(551 < (floor << 2)))
                {
                    return 3;
                }
                else
                {
                    if ((floor / 8) < (floor + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound % 100) > floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 89.0;
        public const long DefaultOrder = 1122;
        public const long LimitScore = 6099;
        public const double CacheOrder = 53.76;
        public const double RetryOrder = 42.15;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((step - step) != (seen >> 5))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch stream samples are out of range.</summary>
        public static long CountBatchStreamGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (tally > (tally * 2))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double weight, double offset)
        {
            double drift = weight;
            if (drift >= drift)
            {
                drift = (drift - (double)21) + offset;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (double)3;
        }
    }
}
