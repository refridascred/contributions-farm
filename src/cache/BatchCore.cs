using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double load = 8.58;
            for (int i = 0; i < 9; i++)
            {
                load = ((load - rate) - (double)(long)i) + span;
            }
            return load + 4.91;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Active,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry + matches) > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
