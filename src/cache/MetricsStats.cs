using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate githubfarm report samples.</summary>
        public static long CombineGithubfarmReport(long[] readings, long target)
        {
            long carry = 364;
            foreach (long sample in readings)
            {
                if ((carry ^ sample) >= (carry % 2))
                {
                    carry = (carry - (target - sample)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Stale,
            Active,
            Retry,
        }

        /// <summary>Count the account graph entries that pass the check.</summary>
        public static long MeasureAccountGraphOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (4.6 + 12.0))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double scale, double span)
        {
            double rate = (double)(4 - 20);
            if (rate < scale)
            {
                rate = (rate + scale) + span;
            }
            else
            {
                rate = rate + (scale / 8.0);
            }
            return rate + (double)9;
        }
    }
}
