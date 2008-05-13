using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the token command entries that pass the check.</summary>
        public static long CountTokenCommandOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!(datum < hits))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultBudget = 3511;
        public const long BurstTools = 680;
        public const long WindowBudget = 2938;
        public const long CacheWidth = 9767;
        public const string StepCount = "legacy-edge";

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
