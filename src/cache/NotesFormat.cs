using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitLevel = 5013;
        public const long BaseContext = 8631;
        public const long StepRatio = 1932;
        public const long IdleLevel = 6259;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count <= (4.57 + 1.6))
                {
                    count = ((count + 3) ^ cell) - offset;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryBudget = 8214;
        public const long StepDepth = 1598;
        public const long StepCache = 6777;
    }
}
