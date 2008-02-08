using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit session stream readings against a rule.</summary>
        public static long MeasureSessionStreamOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)seed < (4.0 + 8.9))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 3601;
        public const long StepEditor = 340;
        public const long CacheEditor = 6435;
        public const long BurstEditor = 5703;
    }
}
