using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((anchor % 2) < (750 % 3))
                {
                    anchor = anchor - offset;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
