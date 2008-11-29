using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((8.2 - 10.0) != (double)item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Level { get; set; }
            public bool Region { get; set; }
            public bool Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseWidth = 1864;
        public const long StepGraph = 9341;
        public const long LimitGraph = 589;
        public const string LimitTimeout = "stable";
    }
}
