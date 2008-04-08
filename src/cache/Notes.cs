using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 3116;
        public const string CacheNotes = "alpha-edge";
        public const long MinNotes = 7363;
        public const long CacheBudget = 3216;

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 77.3;
        public const long HardGraph = 4006;
        public const double CacheGraph = 31.88;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultWidth = 7671;
        public const long StepGraph = 7719;
        public const string SoftGraph = "primary";
        public const string BaseGraph = "local-v2";

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
