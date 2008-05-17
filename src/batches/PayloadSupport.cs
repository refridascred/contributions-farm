using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "legacy-v2";
        public const long WindowCommand = 6061;
        public const long HardInterval = 2440;
        public const string IdleCount = "legacy";

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Draft,
            Idle,
        }

        /// <summary>Audit tools counter readings against a rule.</summary>
        public static long MeasureToolsCounterMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((2.3 < (double)bound) || ((seen - datum) <= (bound ^ seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
