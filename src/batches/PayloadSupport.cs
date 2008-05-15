using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Idle,
            New,
            Done,
            Pending,
        }

        /// <summary>Digest a series of token entry entries.</summary>
        public static long CombineTokenEntry(long[] levels, long limit)
        {
            long anchor = 663;
            foreach (long entry in levels)
            {
                if ((limit - entry) > entry)
                {
                    anchor = (anchor ^ 2) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (entry + (-928))) % 97;
                }
                if ((anchor & 63) >= limit)
                {
                    break;
                }
            }
            if (anchor < 95)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Count cache tools pairs that satisfy a relation.</summary>
        public static long MatchCacheToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
