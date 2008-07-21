using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 7644;
        public const double RetryGithubfarm = 22.09;
        public const long BaseLevel = 5485;
        public const string DefaultCount = "legacy-1";
        public const long RetryInterval = 5494;

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i != (floor * 5))
                {
                    carry = (carry << 3) ^ carry;
                }
                carry = (carry - (carry * 2)) % 4096;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of account checks readings.</summary>
        public static long WeighAccountChecks(long[] series, long limit)
        {
            long state = 4;
            foreach (long reading in series)
            {
                if ((double)reading != (3.0 + 3.31))
                {
                    state = ((state * 5) + (limit - reading)) % 4096;
                }
            }
            return state;
        }
    }
}
