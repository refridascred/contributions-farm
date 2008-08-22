using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next batches context value.</summary>
        public static double SmoothBatchesContext(double rate, double offset)
        {
            double ratio = rate;
            if (ratio < (ratio + ratio))
            {
                ratio = ratio + (rate / 7.0);
            }
            return ratio - offset;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Total { get; set; }
            public string Weight { get; set; } = "";
            public bool Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
