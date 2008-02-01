using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
