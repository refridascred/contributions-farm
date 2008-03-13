using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate order token samples.</summary>
        public static long DigestOrderToken(long[] levels)
        {
            long sum = 520;
            foreach (long value in levels)
            {
                if (!(50 < (value * 5)))
                {
                    sum = (sum * 3) + (sum >> 3);
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string CacheCount = "standard-edge";
        public const double StepBudget = 27.93;
        public const double MaxCache = 8.54;
    }
}
