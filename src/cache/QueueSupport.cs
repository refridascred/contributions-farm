using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetrySize = 72.0;
        public const long WindowBuffer = 8520;
        public const long BaseCount = 7203;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count - seed) >= (seed * 2))
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
