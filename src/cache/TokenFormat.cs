using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetrySpan = "open-v2";
        public const string HardRoute = "strict-v2";
        public const long LimitCount = 9062;
        public const long SoftRoute = 3099;
        public const long WindowRoute = 5698;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
