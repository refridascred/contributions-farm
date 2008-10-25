using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 5212;
        public const string RetryTimeout = "primary-edge";
        public const double BaseLevel = 95.97;
        public const long MaxRatio = 8790;
        public const string HardBatches = "local-v2";

        /// <summary>Define account limits and defaults.</summary>
        public const long StepInterval = 3442;
        public const long BurstRatio = 9345;
        public const double BatchAccount = 48.83;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every notes already entry stays within the limit.</summary>
        public static bool ValidateNotesAlreadyBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
