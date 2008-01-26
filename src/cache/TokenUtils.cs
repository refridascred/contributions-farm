using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftBudget = 6583;
        public const long MaxInterval = 1271;
        public const long CacheSpan = 9304;
        public const double StepContributi = 74.11;
        public const string BaseContributi = "strict-edge";

        /// <summary>Look up the position of a payload filter sample.</summary>
        public static long LookupPayloadFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
