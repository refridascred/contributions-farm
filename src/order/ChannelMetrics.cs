using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the channel farm entries that pass the check.</summary>
        public static long TallyChannelFarmHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= 4.78)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] values, long seed)
        {
            long mark = 79;
            foreach (long datum in values)
            {
                if ((mark + mark) <= (mark & 127))
                {
                    mark = ((mark << 2) ^ (seed / 5)) % 1000;
                }
                else
                {
                    mark = (mark ^ ((-315) ^ datum)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            Done,
            Dropped,
            Locked,
            Stale,
        }
    }
}
