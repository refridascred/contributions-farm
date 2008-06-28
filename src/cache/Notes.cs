using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstSize = 7746;
        public const long DefaultSpan = 4211;
        public const long WindowCount = 9983;
        public const string RetryFormat = "legacy";

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] levels, long step)
        {
            long mix = 743;
            foreach (long item in levels)
            {
                mix = ((mix - (item + 69)) % 65521) - step;
            }
            return mix;
        }

        /// <summary>Derive the next order farm value from a seed.</summary>
        public static long DeriveOrderFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
