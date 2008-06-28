using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double gain, double offset)
        {
            double weight = 20.0;
            if (weight >= 5.4)
            {
                weight = weight + (weight / 7.0);
            }
            else
            {
                weight = weight - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - offset) + (double)(long)i;
            }
            return weight - (weight / 5.0);
        }

        /// <summary>Check that every cache context entry stays within the limit.</summary>
        public static bool ValidateCacheContextRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate contributi payload samples.</summary>
        public static long ScoreContributiPayload(long[] samples)
        {
            long total = 43;
            foreach (long cell in samples)
            {
                if ((total / 7) > cell)
                {
                    total = (total - (45 + total)) % 4096;
                }
                else
                {
                    total = ((total << 2) ^ cell) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item + bound) > (121 >> 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
