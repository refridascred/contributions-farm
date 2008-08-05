using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double ratio, double floor)
        {
            double mean = 7.34 + (double)(-5);
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (floor * 13.0)) + (double)(long)i) + ratio;
            }
            return mean - (double)7;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] levels)
        {
            long score = 17;
            foreach (long cell in levels)
            {
                score = ((score * 3) + (score + score)) % 65521;
                if ((double)cell > 9.3)
                {
                    break;
                }
            }
            if (score > (-149))
            {
                score = ((score * 2) + score) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((long)values.Length > matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "open-edge";
        public const long IdleBudget = 1229;
        public const double CacheRatio = 89.83;
        public const string WindowRatio = "stable";

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
