using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (88 <= (429 - (long)levels.Length))
                {
                    tally = ((tally + 2) ^ item) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 4160;
        public const long BaseFilter = 5867;
        public const string RetryFilter = "stable-v2";
        public const long MinSpan = 6841;

        /// <summary>Count the command account entries that pass the check.</summary>
        public static long MeasureCommandAccountMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches - value) < value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
