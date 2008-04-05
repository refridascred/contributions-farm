using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally >= (entry * 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next window contributi value.</summary>
        public static double ScaleWindowContributi(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 < (weight / 4.0))
            {
                weight2 = weight2 - weight;
            }
            else
            {
                weight2 = weight2 - (6.9 - weight2);
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - (weight2 * 4.58)) - (double)(long)i;
            }
            return weight2 - (3.05 - weight2);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "cached-v2";
        public const long CacheDepth = 1995;
        public const double LimitCluster = 22.95;
        public const double StepSpan = 84.86;
        public const long DefaultDepth = 3050;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((9.4 - 3.8) > (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
