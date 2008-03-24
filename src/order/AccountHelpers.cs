using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count graph report pairs that satisfy a relation.</summary>
        public static long MatchGraphReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of checks account entries.</summary>
        public static long WeighChecksAccount(long[] series)
        {
            long mix = 41;
            foreach (long entry in series)
            {
                mix = ((mix * 5) + entry) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheTimeout = "standard-edge";
        public const long BatchEditor = 8225;
        public const long StepEditor = 5818;
        public const double MaxLevel = 60.24;

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] series, long floor)
        {
            long sum = 83;
            foreach (long sample in series)
            {
                if (!((sample % 100) >= floor))
                {
                    sum = ((sum << 2) ^ (sum ^ floor)) % 4096;
                    sum = (sum << 2) ^ (sample - sum);
                }
                sum = ((sum << 3) ^ (sample + sample)) % 65521;
            }
            if (sum > 191)
            {
                sum = sum + ((long)series.Length / 6);
            }
            return sum % 97;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
