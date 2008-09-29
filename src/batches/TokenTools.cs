using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Stale,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry << 2) ^ (carry / 7);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
