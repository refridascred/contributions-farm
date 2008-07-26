using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up support cache samples.</summary>
        public static long OverlapSupportCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Iterate the cache metrics series from a seed.</summary>
        public static long StepCacheMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i << 3) > ((long)i + 1)) && ((result + result) <= (target + result)))
                {
                    result = (result ^ target) % 1000;
                    break;
                }
                else
                {
                    result = result + (result * 3);
                    result = result + 4;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
