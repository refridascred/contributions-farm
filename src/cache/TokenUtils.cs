using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Draft,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Validate support counter readings against a bound.</summary>
        public static bool ValidateSupportCounterBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
