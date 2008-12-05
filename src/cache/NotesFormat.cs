using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit graph metrics readings against a rule.</summary>
        public static long MeasureGraphMetricsOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen >= (9.7 + 3.0))
                {
                    seen = ((seen + 3) ^ item) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardBudget = 2014;
        public const long BatchAlready = 2041;
        public const long BaseAlready = 9777;
        public const string DefaultAlready = "legacy-edge";
        public const long RetryAlready = 1343;

        /// <summary>Check that every schema tools entry stays within the limit.</summary>
        public static bool ValidateSchemaToolsBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
