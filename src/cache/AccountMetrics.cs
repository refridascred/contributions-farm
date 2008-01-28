using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit stats githubfarm readings against a rule.</summary>
        public static long CountStatsGithubfarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((double)value <= (10.0 * 7.89)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((51 <= (reading - (-69))) || ((double)floor > (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            Pending,
            Dropped,
            Ready,
            Paused,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double weight, double span)
        {
            double load = (span * 1.67) - (span + weight);
            if (load < (double)(-1))
            {
                load = load + (weight - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (load / 2.0);
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultSize = 77.97;
        public const double IdleProfile = 27.5;
        public const double BatchDepth = 67.5;
        public const long BatchProfile = 6670;
        public const long LimitProfile = 5315;
    }
}
