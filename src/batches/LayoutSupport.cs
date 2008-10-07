using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank checks githubfarm input into a small class.</summary>
        public static long RankChecksGithubfarm(long bound, long seed)
        {
            long lane = bound - seed;
            if ((lane ^ 3) > lane)
            {
                return 2;
            }
            else
            {
                if ((seed + lane) != (lane * 3))
                {
                    return 7;
                }
                else
                {
                    if (0 >= (lane - 579))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Count { get; set; }
            public bool Region { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Done,
            Queued,
            New,
            Dropped,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
        }
    }
}
