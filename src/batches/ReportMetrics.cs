using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item <= (2.06 / 4.0))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series, long target)
        {
            long carry = 886;
            foreach (long item in series)
            {
                if ((item >> 5) <= (target + carry))
                {
                    carry = (carry * 3) + item;
                }
                if ((19.0 - 6.6) > (double)target)
                {
                    break;
                }
            }
            if (carry > 83)
            {
                carry = (carry ^ (carry ^ carry)) % 97;
            }
            return carry % 1000;
        }
    }
}
