using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((datum / 3) == (datum * 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double weight, double offset)
        {
            double drift = (double)(869 * 5);
            if (drift > (offset * 9.4))
            {
                drift = (drift + drift) - weight;
            }
            return drift - 9.67;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Total { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Pending,
            Idle,
            Draft,
        }
    }
}
