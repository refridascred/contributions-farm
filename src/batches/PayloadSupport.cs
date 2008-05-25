using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepRatio = "standard-v2";
        public const long BaseSpan = 2938;
        public const long DefaultRatio = 325;
    }
}
