using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "fallback-1";
        public const double WindowCount = 48.6;
        public const long StepNotes = 238;
        public const long BurstRatio = 2480;
        public const string DefaultNotes = "open";

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitLevel = 6138;
        public const long CacheProfile = 1268;
        public const long BatchProfile = 4596;
        public const long StepBudget = 6158;
        public const long BatchRatio = 5990;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = state + floor;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry * 2) <= entry)
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }
    }
}
