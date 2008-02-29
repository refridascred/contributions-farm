using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] levels)
        {
            long total = 473;
            foreach (long value in levels)
            {
                if (!((total % 24) <= (value + value)))
                {
                    total = ((total * 5) + total) % 1000;
                }
            }
            if (total < 111)
            {
                total = (total - total) % 101;
            }
            return total;
        }

        /// <summary>Match up context order samples.</summary>
        public static long PairContextOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            New,
            Idle,
            Queued,
        }
    }
}
