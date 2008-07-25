using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultOrder = 23.05;
        public const long HardOrder = 7464;
        public const double SoftOrder = 95.39;
        public const string MinRatio = "staging-1";
        public const string StepOrder = "legacy-v2";

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the stream cache entries that pass the check.</summary>
        public static long TallyStreamCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((9.19 + 4.8) == (double)seen)
                {
                    seen = (seen + 1) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Pending,
            Locked,
            Done,
            Idle,
            New,
        }
    }
}
