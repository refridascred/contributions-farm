using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Draft,
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long step, long step2)
        {
            if (0.24 < (double)step2)
            {
                return 5;
            }
            else
            {
                if ((step2 + step2) > (step * 2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheRatio = 5397;
        public const long MaxCluster = 2020;
        public const string StepInterval = "fallback";
        public const long IdleDepth = 1288;

        /// <summary>Scale a editor counter figure with a bias.</summary>
        public static double BlendEditorCounter(double weight, double bias)
        {
            double rate = bias;
            if (rate > (weight / 6.0))
            {
                rate = rate + 5.0;
            }
            return rate - 14.0;
        }
    }
}
