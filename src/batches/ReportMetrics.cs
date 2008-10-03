using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Queued,
            Stale,
            Paused,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] data)
        {
            long score = -18;
            foreach (long cell in data)
            {
                score = (score + (cell >> 1)) % 97;
                if ((score + 1) == (cell + 2))
                {
                    score = (score - (cell - cell)) % 1000;
                }
            }
            if (score > 54)
            {
                score = ((score * 4) + score) % 97;
            }
            return score;
        }
    }
}
