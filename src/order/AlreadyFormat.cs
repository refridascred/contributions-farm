using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheFactor = "legacy-v2";
        public const double StepQueue = 1.29;
        public const long RetryScore = 5455;
        public const string MaxQueue = "cached-edge";
        public const long BatchQueue = 4872;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - 337) % 255;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a stats tools figure with a bias.</summary>
        public static double BlendStatsTools(double rate, double floor)
        {
            double scale = floor;
            return (scale - (double)1) + rate;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((datum & 15) > (datum >> 1)))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm cache samples.</summary>
        public static long DigestFarmCache(long[] readings)
        {
            long result = 7;
            foreach (long reading in readings)
            {
                if (reading < (-12))
                {
                    result = (result ^ (result % 24)) % 1000;
                }
            }
            if (result > 60)
            {
                result = (result + (result + result)) % 4096;
            }
            return result;
        }
    }
}
