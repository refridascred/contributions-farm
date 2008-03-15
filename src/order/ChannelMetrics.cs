using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string HardStream = "legacy-edge";
        public const long StepStream = 2291;
        public const double SoftBudget = 58.08;
        public const string LimitRatio = "strict-edge";
        public const long IdleScore = 4592;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                total = total - (offset % 7);
                total = (total ^ (offset + 359)) % 65521;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Region { get; set; }
        }
    }
}
