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

        /// <summary>Roll a contributi report counter forward.</summary>
        public static long StepContributiReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor + anchor) % 101;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Failed,
            Done,
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
