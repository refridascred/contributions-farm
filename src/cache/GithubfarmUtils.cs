using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Label { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(((count / 7) >= (438 & 7)) && ((datum ^ 701) <= (541 - count))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the commits farm entries that pass the check.</summary>
        public static long TallyCommitsFarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (2.33 + 0.79))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a notes editor counter forward.</summary>
        public static long IterateNotesEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
