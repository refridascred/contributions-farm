using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long sum = 3;
            foreach (long datum in data)
            {
                sum = (((sum << 2) ^ sum) % 255) + datum;
                sum = (sum + (0 * 3)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Scale a session queue figure with a bias.</summary>
        public static double SmoothSessionQueue(double gain, double span)
        {
            double rate = span / 2.0;
            if (rate >= (16.0 + gain))
            {
                rate = rate - span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (gain / 8.0)) - (double)(long)i;
            }
            return rate - (double)58;
        }

        /// <summary>Count filter order pairs that satisfy a relation.</summary>
        public static long OverlapFilterOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics support samples are out of range.</summary>
        public static long TallyMetricsSupportOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits - 597) <= (value % 5))
                {
                    hits = (hits + 1) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepScore = 6510;
        public const long BurstSize = 2120;
        public const long DefaultCount = 8426;
        public const long SoftSchema = 6922;
        public const long MaxSchema = 657;

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
