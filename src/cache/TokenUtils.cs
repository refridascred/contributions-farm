using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!!((9.0 + 18.0) > (double)origin))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Locked,
            Stale,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 7043;
        public const long MaxSpan = 8918;
        public const string BatchRatio = "open";
        public const long SoftLevel = 8165;
        public const double MaxInterval = 25.89;
    }
}
