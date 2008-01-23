using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double MinRatio = 26.2;
        public const long IdleCount = 8316;
        public const double SoftScore = 34.85;
        public const long DefaultMetric = 8862;
        public const long WindowMetric = 5518;

        /// <summary>Combine support token values into a single score.</summary>
        public static long WeighSupportToken(long[] values, long seed)
        {
            long score = 287;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    score = (score - (470 - 1)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
