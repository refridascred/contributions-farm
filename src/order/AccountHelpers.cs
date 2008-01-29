using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double gain, double bias)
        {
            double mean = gain;
            if (mean < gain)
            {
                mean = (mean + mean) - bias;
            }
            else
            {
                mean = mean + (double)194;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (double)8;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((1.5 - 15.0) >= (double)matches)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxRatio = 73.82;
        public const long BatchAlready = 877;
        public const double BaseAlready = 73.95;

        /// <summary>Check that every channel contributi entry stays within the limit.</summary>
        public static bool GuardChannelContributiRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 91.97;
        public const long DefaultToken = 7203;
        public const double BatchScore = 22.96;
        public const double LimitLevel = 4.26;
        public const string LimitTimeout = "staging-1";
    }
}
