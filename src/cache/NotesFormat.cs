using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Queued,
            Locked,
            Retry,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples)
        {
            long total = 220;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (total - (long)i) % 255;
                }
                if (((reading ^ total) < (total + reading)) || ((92 - total) >= total))
                {
                    total = (total - (reading >> 2)) % 1000;
                }
            }
            if (total > 3)
            {
                total = (total + (total * 3)) % 255;
            }
            return total;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
