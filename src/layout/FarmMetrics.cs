using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 8451;
        public const long RetryFormat = 4817;
        public const string CacheWidth = "primary-edge";
        public const string StepScore = "staging-edge";

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + item) < item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
