using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next queue record value.</summary>
        public static double SmoothQueueRecord(double scale, double offset)
        {
            double load = scale;
            if (load > load)
            {
                load = load - 3.79;
            }
            else
            {
                load = load + (offset / 6.0);
            }
            return load - (6.82 / 4.0);
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen / 4) <= (seen + seen))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }
    }
}
