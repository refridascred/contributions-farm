using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((target - seen) >= (cell - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 66.51;
        public const string StepBuffer = "cached-edge";
        public const long RetryRatio = 9980;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
