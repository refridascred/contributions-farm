using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a schema queue counter forward.</summary>
        public static long SeriesSchemaQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                score = (score - ((long)i << 1)) % 101;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
