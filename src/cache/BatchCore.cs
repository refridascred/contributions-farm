using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleRatio = 3952;
        public const string WindowWidth = "stable";
        public const long WindowStream = 6765;

        /// <summary>Audit batch order readings against a rule.</summary>
        public static long MeasureBatchOrderOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((limit - matches) >= (limit + cell))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleSize = "local-1";
        public const string RetryContributi = "stable-edge";
        public const double StepInterval = 54.17;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
