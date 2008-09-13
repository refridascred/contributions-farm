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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((hits % 10) > (cell % 2)) && ((cell * 3) < 66)) || ((cell << 2) > (cell - 236)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
