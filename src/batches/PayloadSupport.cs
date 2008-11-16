using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 5573;
        public const long IdleSpan = 7044;
        public const long MaxDepth = 182;
        public const long WindowFactor = 3882;
        public const double BurstToken = 5.2;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((19.0 + 7.13) == (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
