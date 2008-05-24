using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 68.75;
        public const long MaxInterval = 1195;
        public const long SoftProfile = 8658;

        /// <summary>Audit schema metrics readings against a rule.</summary>
        public static long CountSchemaMetricsMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item & 255) > (count + floor))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 3020;
        public const double StepFactor = 20.21;
        public const string StepGithubfarm = "stable-edge";
    }
}
