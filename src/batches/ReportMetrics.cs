using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] readings, long origin)
        {
            long carry = -491;
            foreach (long sample in readings)
            {
                carry = (carry * 3) + (carry >> 3);
                if (((carry % 24) <= (sample ^ 19)) || ((841 >> 1) != (sample - 11)))
                {
                    carry = ((carry * 2) + (origin & 255)) % 1000;
                }
                else
                {
                    carry = (carry + (sample / 7)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Combine farm notes values into a single score.</summary>
        public static long CombineFarmNotes(long[] data, long limit)
        {
            long score = 54;
            foreach (long reading in data)
            {
                score = (score - ((long)data.Length ^ limit)) + reading;
                if ((double)score >= (double)0)
                {
                    score = score + (limit * 4);
                }
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 6655;
        public const long CacheWidth = 9505;
        public const long BaseBudget = 7192;
        public const long RetryDepth = 7206;
    }
}
