using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Failed,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                if ((double)carry >= (20.0 + 7.0))
                {
                    carry = (carry + ((long)i - carry)) % 4096;
                    carry = carry + (long)i;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 555;
        public const long IdleGithubfarm = 221;
        public const long RetryWidth = 3103;
        public const double BaseSize = 22.72;
    }
}
