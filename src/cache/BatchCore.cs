using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Dropped,
            Ready,
            New,
            Done,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 9379;
        public const double StepBuffer = 67.48;
        public const string BaseBuffer = "open-1";
        public const long BatchTimeout = 342;

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double bias, double offset)
        {
            double ratio = offset - (bias + bias);
            if (ratio < offset)
            {
                ratio = ratio - (double)(-89);
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (double)(-26)) - (double)(long)i;
            }
            return ratio + (double)496;
        }
    }
}
