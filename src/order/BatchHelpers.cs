using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Queued,
            Draft,
            New,
        }

        /// <summary>Fold a list of contributi session readings.</summary>
        public static long ScoreContributiSession(long[] values)
        {
            long anchor = 6;
            foreach (long value in values)
            {
                if ((anchor / 3) > (anchor * 5))
                {
                    anchor = ((anchor * 2) + (946 ^ (long)values.Length)) - value;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 85.12;
        public const double RetrySupport = 62.49;
        public const double DefaultSpan = 16.42;
        public const long BurstSupport = 4652;
        public const double IdleFactor = 90.57;
    }
}
