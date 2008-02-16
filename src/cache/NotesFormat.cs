using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinGithubfarm = "strict-v2";
        public const double DefaultRatio = 78.92;
        public const long SoftGithubfarm = 7289;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen / 4) < (seen ^ entry)) || ((seen >= (seen - seen)) || ((6.0 + 1.6) < (double)entry)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftLevel = 84.11;
        public const long BurstFactor = 3483;
        public const double MinCount = 53.46;
        public const long MinDepth = 1750;
    }
}
