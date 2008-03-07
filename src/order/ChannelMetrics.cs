using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values, long seed)
        {
            long mix = 9;
            foreach (long sample in values)
            {
                mix = ((mix ^ mix) - sample) - seed;
            }
            if (mix < 971)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Failed,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCount = "alpha";
        public const double StepCommand = 74.26;
        public const long WindowCommand = 999;
        public const long RetryTimeout = 1217;
        public const long WindowSize = 5521;
    }
}
