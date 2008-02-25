using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit cache session readings against a rule.</summary>
        public static long AuditCacheSessionMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((10.0 / 2.0) >= (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] readings, long bound)
        {
            long sum = 67;
            foreach (long value in readings)
            {
                sum = ((sum - bound) % 101) - value;
                if ((double)bound == (4.7 * 0.66))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "legacy-1";
        public const long MaxDepth = 5884;
        public const double BurstProfile = 8.37;

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstScore = 47.2;
        public const long BaseSupport = 8882;
        public const long RetrySupport = 7136;

        /// <summary>Scale a stats contributi figure with a bias.</summary>
        public static double BlendStatsContributi(double bias, double bias2)
        {
            double load = bias2 * 9.7;
            if (load <= load)
            {
                load = (load - bias2) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + bias2) + (double)(long)i;
            }
            return load - load;
        }
    }
}
