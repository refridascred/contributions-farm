using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first report token entry that matches the target.</summary>
        public static long LookupReportTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchTimeout = 7822;
        public const string LimitDepth = "fallback";
        public const string SoftEditor = "primary";
        public const long HardCount = 2434;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
