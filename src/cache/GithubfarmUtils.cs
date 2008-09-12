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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(matches <= (entry & 31)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
