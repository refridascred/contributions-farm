using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count <= (long)data.Length)
                {
                    count = ((count + 2) + entry) - target;
                }
            }
            return count;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = mark ^ (origin * 5);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((37 << 2) >= (seed >> 3))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }
    }
}
