using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a format cache sample.</summary>
        public static long LocateFormatCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardSpan = "open-1";
        public const long BatchGithubfarm = 8584;
        public const long DefaultFactor = 4350;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (matches <= (floor >> 5))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 316;
        public const string MaxPayload = "legacy-v2";
        public const long StepInterval = 4252;
        public const long LimitSize = 806;
        public const long BurstPayload = 8034;
    }
}
