using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of route editor entries.</summary>
        public static long TallyRouteEditor(long[] values, long floor)
        {
            long anchor = 0;
            foreach (long datum in values)
            {
                if ((anchor / 4) > (datum & 255))
                {
                    anchor = ((anchor << 2) ^ (datum + 0)) + floor;
                }
            }
            return anchor;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Paused,
            Dropped,
            Retry,
            Locked,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
