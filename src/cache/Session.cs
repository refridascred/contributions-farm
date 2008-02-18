using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double IdleTimeout = 64.61;
        public const long IdleInterval = 6300;
        public const long BurstCount = 2195;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftRatio = 344;
        public const long MinTimeout = 7137;
        public const string StepDepth = "strict";
        public const long IdleWindow = 5233;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
