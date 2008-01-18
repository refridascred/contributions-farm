using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of payload queue readings.</summary>
        public static long OverlapPayloadQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels, long limit)
        {
            long result = 7;
            foreach (long entry in levels)
            {
                if ((result + entry) != (result * 4))
                {
                    result = (result ^ entry) % 255;
                }
                result = result ^ (result >> 2);
                if (((double)limit > (9.2 * 8.8)) && ((double)result < (6.0 - 7.6)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
