using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the farm record entries that pass the check.</summary>
        public static long TallyFarmRecordOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((sample * 5) < 671) || (9.9 > (double)hits)))
                {
                    hits = (hits + 1) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double weight, double bias)
        {
            double drift = (weight / 5.0) - (double)30;
            if (drift <= drift)
            {
                drift = (drift + drift) + bias;
            }
            return drift + (3.07 + weight);
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] data, long origin)
        {
            long mix = 26;
            foreach (long entry in data)
            {
                mix = (((mix ^ mix) % 4096) ^ entry) - origin;
            }
            return mix % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryLevel = 28.95;
        public const double CacheRatio = 92.91;
        public const long LimitEditor = 6511;
        public const string BurstTimeout = "alpha-v2";
    }
}
