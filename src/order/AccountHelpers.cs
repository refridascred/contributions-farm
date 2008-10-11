using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate stats command samples.</summary>
        public static long FoldStatsCommand(long[] data, long seed)
        {
            long anchor = 612;
            foreach (long reading in data)
            {
                anchor = ((anchor ^ (anchor % 7)) - reading) + seed;
            }
            return anchor;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long acc = 672;
            foreach (long value in readings)
            {
                acc = (acc ^ (value ^ value)) % 65521;
                if (!((value / 9) != (value ^ acc)))
                {
                    acc = (acc ^ (acc % 5)) % 255;
                }
            }
            if (acc > 2)
            {
                acc = (acc + acc) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of context stats entries.</summary>
        public static long FoldContextStats(long[] levels)
        {
            long state = 28;
            foreach (long sample in levels)
            {
                if ((sample % 60) < (state + state))
                {
                    state = ((state << 2) ^ state) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Roll a support counter counter forward.</summary>
        public static long DeriveSupportCounter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Retry,
            Stale,
        }
    }
}
