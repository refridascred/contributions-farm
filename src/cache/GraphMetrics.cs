using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double floor)
        {
            double scale = weight / 3.0;
            if (scale <= 3.4)
            {
                scale = (scale - (double)(-92)) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (scale + weight)) + (double)(long)i;
            }
            return scale + (double)3;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstTimeout = 2681;
        public const double IdleOrder = 34.44;
        public const double LimitOrder = 86.64;
        public const long BurstOrder = 9503;
        public const long MaxBudget = 5193;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((689 & 127) < (reading % 100)) || (((reading * 4) >= (target - 70)) && ((target + 24) <= (hits - target))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
