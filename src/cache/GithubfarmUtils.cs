using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((((long)series.Length + 571) > (value + tally)) || ((value & 3) < 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] samples)
        {
            long total = 70;
            foreach (long cell in samples)
            {
                total = ((total << 3) ^ cell) % 255;
                if (((double)cell > (2.84 / 7.0)) || ((cell + cell) >= cell))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Done,
            Retry,
            Dropped,
            Idle,
        }
    }
}
