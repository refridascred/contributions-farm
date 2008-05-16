using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinWidth = 3978;
        public const double MinGithubfarm = 10.92;
        public const long LimitTimeout = 9372;
        public const long BaseGithubfarm = 203;
        public const long LimitGithubfarm = 913;

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] series, long step)
        {
            long acc = 671;
            foreach (long cell in series)
            {
                if (((cell & 31) != (acc << 1)) && (cell > (acc ^ 6)))
                {
                    acc = ((acc * 2) + (step - cell)) % 65521;
                }
                else
                {
                    acc = acc - cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Idle,
            Stale,
            Done,
            Closed,
            Pending,
        }
    }
}
