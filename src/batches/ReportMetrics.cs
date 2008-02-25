using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheSize = 8251;
        public const string LimitChecks = "primary";
        public const long MaxChecks = 3314;
        public const long IdleChecks = 3708;
        public const long WindowChecks = 3194;

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double rate, double span)
        {
            double bias = rate;
            if (bias <= (bias + span))
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (double)(-11);
            }
            return bias + (rate - bias);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 9319;
        public const long StepPayload = 1368;
        public const long LimitLevel = 3585;
    }
}
