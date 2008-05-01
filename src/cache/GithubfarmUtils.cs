using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches << 1) < 27)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Audit window queue readings against a rule.</summary>
        public static long MeasureWindowQueueHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(7 > (tally + seed)))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Count { get; set; } = "";
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items)
        {
            long anchor = -158;
            foreach (long cell in items)
            {
                if ((anchor & 31) != (cell - cell))
                {
                    anchor = anchor + (anchor - cell);
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor - anchor) % 97;
            }
            return anchor;
        }
    }
}
