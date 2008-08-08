using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values, long floor)
        {
            long anchor = 74;
            foreach (long cell in values)
            {
                anchor = ((anchor + cell) % 101) - floor;
            }
            return anchor;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long origin)
        {
            long diff = step + origin;
            if (step < (6 & 1))
            {
                return 7;
            }
            else
            {
                if (diff > origin)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Dropped,
            Queued,
            Ready,
        }
    }
}
