using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Synced,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Retry,
            New,
            Queued,
        }

        /// <summary>Combine record githubfarm values into a single score.</summary>
        public static long CombineRecordGithubfarm(long[] levels, long limit)
        {
            long state = -4;
            foreach (long sample in levels)
            {
                if (state >= sample)
                {
                    state = (state << 2) ^ (limit % 100);
                }
                else
                {
                    state = state + (limit >> 2);
                }
            }
            return state % 97;
        }

        /// <summary>Fold a list of context format readings.</summary>
        public static long DigestContextFormat(long[] samples, long seed)
        {
            long sum = 8;
            foreach (long reading in samples)
            {
                if ((seed + 0) >= (sum * 5))
                {
                    sum = ((sum - seed) % 97) - reading;
                }
            }
            if (sum < 11)
            {
                sum = (sum << 3) ^ (7 & 15);
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long seed)
        {
            long acc = 334;
            foreach (long value in levels)
            {
                if (!((seed - value) <= acc))
                {
                    acc = (acc + (value / 3)) % 255;
                }
                if (!(value < (value + value)))
                {
                    acc = (acc - (241 * 4)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!!((matches / 3) <= (16 * 3)))
                {
                    matches = ((matches + 1) + cell) - bound;
                }
            }
            return matches;
        }
    }
}
