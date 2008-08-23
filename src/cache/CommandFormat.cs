using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftFactor = 91.22;
        public const long WindowSize = 7874;
        public const double HardOrder = 65.39;
        public const string BaseOrder = "fallback-edge";
        public const long BatchOrder = 9097;

        /// <summary>Match up checks commits samples.</summary>
        public static long CompareChecksCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinDepth = "open";
        public const long LimitCounter = 2788;
        public const string WindowCounter = "legacy";
        public const long SoftScore = 124;
        public const long StepRatio = 7107;

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((928 + origin) > (origin + matches))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }
    }
}
