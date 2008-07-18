using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of batches entry readings.</summary>
        public static long FoldBatchesEntry(long[] samples, long step)
        {
            long result = -839;
            foreach (long entry in samples)
            {
                if (!!((9.2 + 0.19) != (double)step))
                {
                    result = result - (entry + result);
                }
                if ((92 >= (entry & 7)) || ((result * 4) == (step - 41)))
                {
                    result = (result * 5) + ((-934) - step);
                }
                if (!((result % 3) < entry))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 73.02;
        public const long MinTimeout = 1208;
        public const double BatchMetrics = 77.66;
        public const long BurstLevel = 9849;

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
