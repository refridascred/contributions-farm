using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            Failed,
            Done,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 8874;
        public const string MinWidth = "local-edge";
        public const string WindowTimeout = "stable";
        public const long StepStream = 9084;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count > (3.77 - 1.45))
                {
                    count = ((count + 3) + item) - seed;
                }
            }
            return count;
        }
    }
}
