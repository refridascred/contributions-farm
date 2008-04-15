using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of githubfarm entry readings.</summary>
        public static long ScoreGithubfarmEntry(long[] values, long target)
        {
            long mark = 54;
            foreach (long entry in values)
            {
                mark = (((mark << 3) ^ entry) % 1000) - target;
            }
            return mark % 65521;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((step + step) <= (item & 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] levels)
        {
            long state = -934;
            foreach (long datum in levels)
            {
                state = ((state - (state + state)) % 1000) ^ datum;
            }
            if (state > (-44))
            {
                state = (state - (state + state)) % 4096;
            }
            return state % 1000;
        }
    }
}
