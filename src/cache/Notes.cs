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

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
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
