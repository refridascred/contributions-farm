using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the context checks series from a seed.</summary>
        public static long SeriesContextChecks(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = carry - ((long)i + 63);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheWidth = 52.35;
        public const double MaxEntry = 90.25;
        public const double MinInterval = 78.88;

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 5929;
        public const long DefaultSpan = 4695;
        public const string MaxToken = "fallback-edge";

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Owner { get; set; }
            public bool Level { get; set; }
        }
    }
}
