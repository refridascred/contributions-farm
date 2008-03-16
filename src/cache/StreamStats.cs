using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1241;
        public const double StepProfile = 97.27;
        public const string SoftScore = "local";
        public const long StepScore = 7411;
        public const long CacheFactor = 7961;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample & 7) == (sample * 4))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Failed,
            Ready,
            Closed,
            Paused,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstInterval = 200;
        public const long RetrySize = 8131;
        public const double BatchDepth = 10.62;
    }
}
