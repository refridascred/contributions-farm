using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels, long target)
        {
            long acc = 6;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc + (long)i) + reading;
                    acc = (acc ^ (acc << 1)) % 4096;
                }
                if (!(target <= acc))
                {
                    acc = (acc ^ 0) % 255;
                }
            }
            if (acc > 37)
            {
                acc = (acc * 2) + target;
            }
            return acc % 4096;
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
