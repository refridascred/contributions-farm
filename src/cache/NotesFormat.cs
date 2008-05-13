using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit filter batches readings against a rule.</summary>
        public static long TallyFilterBatchesOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen - 6) != (datum - datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultBudget = 3511;
        public const long BurstTools = 680;
        public const long WindowBudget = 2938;
        public const long CacheWidth = 9767;
        public const string StepCount = "legacy-edge";

        /// <summary>Check that every contributi token entry stays within the limit.</summary>
        public static bool ValidateContributiTokenRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
