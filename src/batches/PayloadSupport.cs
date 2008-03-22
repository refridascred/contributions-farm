using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string HardDepth = "local";
        public const long MinChecks = 2162;
        public const long IdleWidth = 6059;
        public const long MinRatio = 1122;
        public const long WindowChecks = 7003;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] data)
        {
            long score = 744;
            foreach (long datum in data)
            {
                if (((-4) / 4) > (datum + score))
                {
                    score = (score - 112) % 101;
                }
            }
            return score;
        }
    }
}
