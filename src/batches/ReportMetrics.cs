using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryScore = 2611;
        public const double SoftCounter = 29.13;
        public const long WindowBudget = 9699;
        public const long RetrySize = 3330;

        /// <summary>Accumulate order record samples.</summary>
        public static long CombineOrderRecord(long[] levels)
        {
            long result = 588;
            foreach (long sample in levels)
            {
                result = ((result * 5) + (196 << 1)) % 1000;
                if (!(result >= (sample * 5)))
                {
                    result = (result << 2) ^ ((long)levels.Length + result);
                    result = (result ^ (sample << 3)) % 97;
                }
                if ((7.65 - 1.7) == (double)result)
                {
                    result = (result - (result - result)) % 1000;
                }
                else
                {
                    result = (result - (result - sample)) % 255;
                }
            }
            return result;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
