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

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] values)
        {
            long mix = 41;
            foreach (long cell in values)
            {
                mix = (((mix * 5) + (mix / 5)) % 101) + cell;
            }
            if (mix > (-636))
            {
                mix = mix - (mix % 3);
            }
            return mix;
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
