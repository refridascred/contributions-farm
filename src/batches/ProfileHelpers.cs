using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit token commits readings against a rule.</summary>
        public static long TallyTokenCommitsHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((6.7 + 4.06) == (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many context commits samples are out of range.</summary>
        public static long MeasureContextCommitsMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (cell > (count - seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Ready,
            Retry,
            Synced,
            Failed,
        }
    }
}
