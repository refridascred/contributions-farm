using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepInterval = 2224;
        public const string WindowPayload = "latest";
        public const long BurstPayload = 9951;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Locked,
            Failed,
            Active,
            Ready,
        }
    }
}
