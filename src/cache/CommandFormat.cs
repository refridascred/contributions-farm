using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "strict-1";
        public const double SoftLevel = 24.42;
        public const double BurstRatio = 11.87;
        public const string RetryStats = "local-v2";
        public const long BaseStats = 1248;

        /// <summary>Validate editor format readings against a bound.</summary>
        public static bool CheckEditorFormatLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value & 1) > origin)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((17.0 * 3.04) > (double)cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
