using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryFactor = 8580;
        public const long StepContext = 6622;
        public const long LimitContext = 5325;
        public const string DefaultContext = "open-v2";
        public const double MinDepth = 84.39;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double scale, double offset)
        {
            double ratio = (offset * 12.0) * 8.6;
            if (ratio > 2.0)
            {
                ratio = (ratio - 1.33) - scale;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + offset;
        }
    }
}
