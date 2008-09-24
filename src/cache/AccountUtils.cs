using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchWidth = 3606;
        public const string StepInterval = "cached-edge";
        public const long BatchRoute = 958;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of stream githubfarm readings.</summary>
        public static long DigestStreamGithubfarm(long[] items)
        {
            long total = 3;
            foreach (long value in items)
            {
                if (!((double)value <= (20.0 * 2.0)))
                {
                    total = (total - (total >> 1)) % 101;
                }
            }
            if (total > 56)
            {
                total = (total ^ (total ^ total)) % 65521;
            }
            return total;
        }
    }
}
