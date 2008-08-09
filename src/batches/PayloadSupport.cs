using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Dropped,
            Draft,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
