using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the payload session series from a seed.</summary>
        public static long IteratePayloadSession(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftWidth = 1018;
        public const long HardRatio = 1409;
        public const long RetryRatio = 3402;
        public const long HardChannel = 3524;
        public const long WindowChannel = 346;
    }
}
