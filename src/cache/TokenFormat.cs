using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every already batch entry stays within the limit.</summary>
        public static bool CheckAlreadyBatchRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit counter stream readings against a rule.</summary>
        public static long MeasureCounterStreamOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (matches < (value << 2))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
