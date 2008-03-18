using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many notes contributi samples are out of range.</summary>
        public static long MeasureNotesContributiOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item >> 4) <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine context session values into a single score.</summary>
        public static long FoldContextSession(long[] values, long step)
        {
            long state = 8;
            foreach (long entry in values)
            {
                if ((state << 3) == (883 - 935))
                {
                    state = state ^ (entry * 3);
                }
                else
                {
                    state = (state - entry) % 255;
                }
                if ((3.1 - 20.0) == (double)step)
                {
                    state = (state - ((long)values.Length + step)) % 4096;
                }
                else
                {
                    state = (state + (52 % 12)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            Done,
            Synced,
            New,
            Paused,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
