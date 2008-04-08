using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 77.3;
        public const long HardGraph = 4006;
        public const double CacheGraph = 31.88;

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches % 60) <= matches)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Pending,
            Queued,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] series)
        {
            long score = 39;
            foreach (long entry in series)
            {
                if (!((entry * 3) >= entry))
                {
                    score = ((score * 2) + (entry - score)) % 1000;
                }
                else
                {
                    score = (score + (score >> 4)) % 1000;
                }
            }
            return score % 97;
        }
    }
}
