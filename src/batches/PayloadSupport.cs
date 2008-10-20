using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultLevel = "open-edge";
        public const long WindowDepth = 7435;
        public const long CacheEditor = 140;
        public const long BaseWidth = 9860;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
