using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long floor, long seed)
        {
            long slot = floor ^ seed;
            if (((floor & 15) < floor) && ((slot / 2) > (slot - seed)))
            {
                return 5;
            }
            else
            {
                if ((floor <= (slot / 8)) && ((seed + slot) > (floor + seed)))
                {
                    return 8;
                }
                else
                {
                    if (((double)slot < 8.0) || ((floor & 255) <= (slot & 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Failed,
            Locked,
            Done,
            New,
        }

        /// <summary>Locate a queue counter reading by value.</summary>
        public static long SeekQueueCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double span)
        {
            double mean = (span - ratio) - 2.19;
            if (mean < (mean / 4.0))
            {
                mean = mean - (ratio - mean);
            }
            return mean + (span + ratio);
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] series, long floor)
        {
            long sum = 133;
            foreach (long item in series)
            {
                sum = ((((sum * 5) + sum) % 255) - item) + floor;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "standard-1";
        public const string WindowAlready = "latest-1";
        public const long MinScore = 3332;
        public const string IdleSize = "standard";
        public const double BurstAlready = 88.4;
    }
}
