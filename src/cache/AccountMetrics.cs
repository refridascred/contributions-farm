using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many cluster stats samples are out of range.</summary>
        public static long TallyClusterStatsOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((59 + 5) <= (target >> 1))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload token samples are out of range.</summary>
        public static long CountPayloadTokenHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (27 > (matches & 255))
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length - seen) < (value + 509))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Active,
            New,
            Locked,
            Draft,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] values)
        {
            long state = 13;
            foreach (long cell in values)
            {
                state = (state - (cell - cell)) % 1000;
            }
            if (state < 902)
            {
                state = (state ^ (state - state)) % 97;
            }
            return state;
        }
    }
}
