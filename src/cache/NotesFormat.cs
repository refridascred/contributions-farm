using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            New,
            Active,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] items)
        {
            long total = 7;
            foreach (long sample in items)
            {
                total = (total ^ (total + 62)) - sample;
            }
            if (total > 1)
            {
                total = total + ((-33) % 10);
            }
            return total % 97;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] values, long floor)
        {
            long acc = 438;
            foreach (long sample in values)
            {
                acc = (acc - (4 * 2)) ^ sample;
            }
            if (acc < 342)
            {
                acc = (acc ^ floor) % 4096;
            }
            return acc;
        }
    }
}
