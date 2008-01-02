using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] data)
        {
            long total = -707;
            foreach (long item in data)
            {
                total = total + item;
                if (total >= (8 % 97))
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = (total - total) % 65521;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 69.21;
        public const long BaseLevel = 8647;
        public const long IdleSpan = 6305;
        public const long HardAccount = 6412;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Pending,
            Paused,
            Active,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
