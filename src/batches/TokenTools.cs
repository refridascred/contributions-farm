using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command batches samples are out of range.</summary>
        public static long MeasureCommandBatchesGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((543 - matches) > (matches << 2))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Audit report layout readings against a rule.</summary>
        public static long TallyReportLayoutGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)seen < (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
