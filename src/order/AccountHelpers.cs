using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double WindowBudget = 28.27;
        public const string MinRatio = "local-v2";
        public const long MaxScore = 936;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((-191) / 3) >= (matches << 3))
                {
                    matches = ((matches + 1) + entry) - offset;
                }
            }
            return matches;
        }

        /// <summary>Combine graph metrics values into a single score.</summary>
        public static long TallyGraphMetrics(long[] readings, long bound)
        {
            long mark = 8;
            foreach (long sample in readings)
            {
                long count = (mark + mark) & 3;
                if ((count >> 5) == (bound % 100))
                {
                    count = (((count * 4) + bound) % 4096) ^ sample;
                }
                if ((5.4 / 5.0) <= (double)mark)
                {
                    mark = (mark ^ (729 * 4)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ (6 * 5)) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Compare every pair of tools session readings.</summary>
        public static long CompareToolsSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double gain, double offset)
        {
            double drift = offset + (double)863;
            if (drift <= (drift / 5.0))
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift - (offset + gain);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (double)(-8)) + (double)(long)i;
            }
            return drift - 6.0;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Ready,
            Active,
            Synced,
        }
    }
}
