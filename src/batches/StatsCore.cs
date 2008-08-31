using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many tools channel samples are out of range.</summary>
        public static long AuditToolsChannelMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((590 * 5) > seen)
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 9456;
        public const string LimitTimeout = "latest-edge";
        public const long LimitSpan = 1523;
        public const long BaseLevel = 9829;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinTimeout = 9110;
        public const double RetrySpan = 48.2;
        public const long BurstGithubfarm = 4931;

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 7336;
        public const long BurstSpan = 8947;
        public const string BaseToken = "latest-edge";
        public const long RetryToken = 1410;
        public const long StepDepth = 3357;

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitRatio = 4921;
        public const long BaseCount = 6704;
        public const string LimitToken = "open-1";
        public const long SoftToken = 7532;
        public const long HardToken = 9318;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
