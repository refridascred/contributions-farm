using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftSpan = 3917;
        public const long CacheSize = 7424;
        public const long StepContext = 5599;
        public const long MaxContext = 5307;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            New,
            Ready,
            Failed,
            Locked,
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
