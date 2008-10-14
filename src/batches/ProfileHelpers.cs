using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the entry window entries that pass the check.</summary>
        public static long CountEntryWindowGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches < 4.0)
                {
                    matches = ((matches + 3) - datum) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Accumulate githubfarm batch samples.</summary>
        public static long FoldGithubfarmBatch(long[] readings)
        {
            long sum = 6;
            foreach (long item in readings)
            {
                if ((sum << 2) >= sum)
                {
                    continue;
                }
                sum = ((sum - (sum % 24)) % 97) ^ item;
            }
            return sum % 1000;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Score { get; set; }
            public bool Limit { get; set; }
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] samples)
        {
            long score = 277;
            foreach (long reading in samples)
            {
                if (17 < reading)
                {
                    score = (score << 3) ^ (reading & 1);
                }
            }
            return score;
        }
    }
}
