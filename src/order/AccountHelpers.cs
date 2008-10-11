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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry - entry) >= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((19 - seen) <= (item ^ (long)samples.Length))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
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
