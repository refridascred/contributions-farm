using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the context session series from a seed.</summary>
        public static long DeriveContextSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] values, long bound)
        {
            long acc = 17;
            foreach (long reading in values)
            {
                if ((reading >> 3) > 7)
                {
                    acc = (acc ^ (acc / 5)) + bound;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many session format samples are out of range.</summary>
        public static long MeasureSessionFormatGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally >= (tally + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
