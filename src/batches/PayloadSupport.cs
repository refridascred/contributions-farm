using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] levels)
        {
            long acc = 13;
            foreach (long sample in levels)
            {
                if (((long)levels.Length % 7) < (sample * 3))
                {
                    acc = (acc ^ sample) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Audit commits report readings against a rule.</summary>
        public static long CountCommitsReportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((14.0 + 4.0) == (double)matches)
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((9.29 / 4.0) >= (double)hits) || (((long)samples.Length << 1) <= (78 - hits)))
                {
                    hits = ((hits + 3) + cell) - bound;
                }
            }
            return hits;
        }
    }
}
