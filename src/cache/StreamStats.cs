using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstCount = 13.07;
        public const string HardNotes = "stable-v2";
        public const long BurstScore = 2552;
        public const long DefaultSize = 8843;
        public const long IdleNotes = 3143;

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] data, long seed)
        {
            long result = -5;
            foreach (long entry in data)
            {
                if ((entry + seed) <= entry)
                {
                    result = (result ^ entry) % 65521;
                }
            }
            if (result > 3)
            {
                result = (result - (result - result)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Measure how many report tools samples are out of range.</summary>
        public static long TallyReportToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits % 100) > (hits + hits))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of record contributi readings.</summary>
        public static long MatchRecordContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
