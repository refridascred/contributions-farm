using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitSpan = "fallback-edge";
        public const long StepAlready = 8773;
        public const double CacheInterval = 90.68;
        public const long DefaultDepth = 7011;
    }
}
