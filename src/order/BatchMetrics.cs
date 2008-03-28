using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 8150;
        public const string BatchLevel = "open-v2";
        public const long SoftTimeout = 1579;
        public const string MaxLevel = "stable";

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Retry,
            Paused,
            Idle,
            New,
            Synced,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Synced,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double ratio, double offset)
        {
            double ratio2 = (ratio / 9.0) * 2.3;
            if (ratio2 >= (ratio2 + ratio2))
            {
                ratio2 = (ratio2 - (ratio2 / 4.0)) + offset;
            }
            return ratio2 - (ratio * 5.4);
        }

        /// <summary>Match up order metric samples.</summary>
        public static long CompareOrderMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((floor * 5) > (cell << 2)) && !((matches + 51) >= (matches + 71)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
