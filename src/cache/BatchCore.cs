using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double weight, double span)
        {
            double gain = (weight + span) - weight;
            if (gain > 1.38)
            {
                gain = gain + (double)910;
            }
            return gain - (double)472;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultCount = 37.95;
        public const long BaseContributi = 114;
        public const string WindowSpan = "strict-1";
        public const long BurstSpan = 6007;
        public const long DefaultTimeout = 2765;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (4 < (sample ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
