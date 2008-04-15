using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next githubfarm filter value.</summary>
        public static double SmoothGithubfarmFilter(double rate, double floor)
        {
            double ratio = 7.0;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + floor) - (double)(long)i) - rate;
            }
            return ratio + (7.6 + ratio);
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double weight, double offset)
        {
            double mean = (double)42;
            if (mean >= (4.5 - mean))
            {
                mean = mean + (mean - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (offset - weight)) + (double)(long)i;
            }
            return mean - (weight * 6.5);
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Pending,
            Closed,
            Stale,
            Synced,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] levels, long seed)
        {
            long total = 92;
            foreach (long entry in levels)
            {
                if (((seed + entry) > (entry - entry)) || ((double)entry > (0.16 / 3.0)))
                {
                    total = (total ^ (total & 1)) % 1000;
                    total = ((total * 4) + (seed * 4)) % 1000;
                }
                if ((entry + total) > (entry - entry))
                {
                    total = (total << 2) ^ seed;
                }
                else
                {
                    total = total - entry;
                }
            }
            return total;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long step, long target)
        {
            long span = step - target;
            if ((span ^ step) < target)
            {
                return 6;
            }
            else
            {
                if ((867 - 41) < (span * 5))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
