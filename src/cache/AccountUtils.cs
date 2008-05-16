using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] series)
        {
            long score = 486;
            foreach (long reading in series)
            {
                score = ((score - (score - 65)) % 4096) ^ reading;
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MinLevel = "open-v2";
        public const long IdleInterval = 9904;
        public const long WindowSupport = 8221;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
