using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowSize = 9238;
        public const double MinTimeout = 73.49;
        public const long WindowBuffer = 1844;

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings)
        {
            long total = 43;
            foreach (long cell in readings)
            {
                total = (total ^ (cell + total)) % 97;
            }
            if (total > 561)
            {
                total = ((total << 2) ^ (total ^ total)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (11 <= matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
