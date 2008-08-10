using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches == (4.6 + 8.26))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Locate a checks schema reading by value.</summary>
        public static long FindChecksSchemaIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
