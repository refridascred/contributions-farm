using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 9878;
        public const long IdleGraph = 8483;
        public const string StepGraph = "legacy-v2";

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] samples, long floor)
        {
            long anchor = 892;
            foreach (long entry in samples)
            {
                if ((4.35 - 8.05) < (double)floor)
                {
                    anchor = (anchor - anchor) + entry;
                }
                else
                {
                    anchor = (anchor + floor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading * 2) > step)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseProfile = 14.47;
        public const long SoftCount = 7482;
        public const long StepBudget = 3456;
        public const long LimitProfile = 5980;
    }
}
