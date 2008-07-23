using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 736;
        public const long IdleLevel = 2893;
        public const double RetryFilter = 26.69;
        public const long BaseFilter = 1718;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
