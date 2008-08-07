using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 1557;
        public const string LimitQueue = "standard";
        public const long StepQueue = 6866;
        public const long MinWidth = 7273;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
