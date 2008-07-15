using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] readings, long target)
        {
            long score = 27;
            foreach (long item in readings)
            {
                if ((target ^ 7) > (score - target))
                {
                    score = ((score * 2) + score) + item;
                }
            }
            if (score > 0)
            {
                score = ((score * 5) + 7) % 65521;
            }
            return score;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long floor, long floor2)
        {
            long diff = floor ^ floor2;
            if (floor < 56)
            {
                return 6;
            }
            else
            {
                if ((0 + diff) <= (18 / 3))
                {
                    return 8;
                }
                else
                {
                    if ((diff - floor) < floor2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor2 + diff) < floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((2.5 / 9.0) == (double)count)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
