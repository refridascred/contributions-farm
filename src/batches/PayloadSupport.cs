using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftDepth = 7672;
        public const long RetryLayout = 1215;
        public const string StepLayout = "local-edge";
        public const double CacheLevel = 98.42;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 >= (double)870)
            {
                gain2 = gain2 - offset;
            }
            else
            {
                gain2 = gain2 - (gain - gain2);
            }
            return gain2 - 13.0;
        }
    }
}
