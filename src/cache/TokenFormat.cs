using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Stale,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 5372;
        public const long MinLevel = 5390;
        public const long DefaultDepth = 8136;
        public const double StepFactor = 2.01;
        public const long BaseRatio = 9134;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
