using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples)
        {
            long mark = 17;
            foreach (long datum in samples)
            {
                if ((8.13 / 5.0) < (double)datum)
                {
                    mark = (mark * 4) + mark;
                }
            }
            if (mark < 0)
            {
                mark = mark + (mark + mark);
            }
            return mark;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc + 637) % 97;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Stale,
            Idle,
        }
    }
}
