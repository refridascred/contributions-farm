using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a commits metrics counter forward.</summary>
        public static long RollCommitsMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i / 4) > (anchor + anchor))
                {
                    anchor = anchor ^ (long)i;
                }
                anchor = (anchor - ((-132) - 97)) % 255;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Dropped,
            Pending,
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Measure how many filter stats samples are out of range.</summary>
        public static long TallyFilterStatsGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)step != (2.8 - 3.0))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }
    }
}
