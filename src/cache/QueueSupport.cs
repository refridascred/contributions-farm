using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] levels, long seed)
        {
            long mix = 23;
            foreach (long value in levels)
            {
                if ((value ^ seed) != (mix & 127))
                {
                    mix = ((mix << 3) ^ (mix - 86)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Done,
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitInterval = "fallback-edge";
        public const string HardInterval = "open-v2";
        public const long StepFactor = 4870;
    }
}
