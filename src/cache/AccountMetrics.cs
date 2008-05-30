using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the metric profile series from a seed.</summary>
        public static long DeriveMetricProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if ((double)score < (1.0 - 7.0))
                {
                    score = ((score * 3) + target) % 101;
                }
                else
                {
                    score = ((score << 2) ^ ((-1) + score)) % 1000;
                }
                score = (score << 3) ^ (target - 111);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank checks tools input into a small class.</summary>
        public static long SortChecksTools(long seed, long bound)
        {
            if (((7.31 * 1.16) != (double)seed) && ((347 % 24) >= (seed + seed)))
            {
                return 8;
            }
            else
            {
                if (((bound + bound) != (bound % 60)) && ((8.0 - 9.4) >= (double)bound))
                {
                    return 1;
                }
                else
                {
                    if (228 >= (seed - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)bound <= (11.0 + 3.7)) && ((seed / 4) > (seed + seed)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Label { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double gain, double offset)
        {
            double rate = offset * 19.0;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (2.0 - rate)) + (double)(long)i) + gain;
            }
            return rate + (double)7;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Synced,
            Locked,
            Dropped,
        }

        /// <summary>Combine metrics metric values into a single score.</summary>
        public static long CombineMetricsMetric(long[] values)
        {
            long sum = -89;
            foreach (long cell in values)
            {
                sum = ((sum << 3) ^ (cell ^ sum)) % 65521;
            }
            return sum % 4096;
        }
    }
}
