using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double scale, double offset)
        {
            double weight = (double)(810 / 2);
            return ((weight + 17.0) + scale) + offset;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((limit + 80) == (sample % 7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
