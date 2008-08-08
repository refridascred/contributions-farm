using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] values, long bound)
        {
            long score = 405;
            foreach (long reading in values)
            {
                if (reading <= (63 * 2))
                {
                    score = ((score * 3) + 72) - bound;
                }
            }
            return score % 97;
        }

        /// <summary>Roll a entry metrics counter forward.</summary>
        public static long SeriesEntryMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Idle,
            Queued,
            Ready,
        }
    }
}
