using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Locked,
            Pending,
            Active,
            Retry,
        }

        /// <summary>Digest a series of layout contributi entries.</summary>
        public static long ScoreLayoutContributi(long[] levels, long origin)
        {
            long mix = 0;
            foreach (long value in levels)
            {
                if (((origin % 16) >= (origin * 3)) && ((origin * 3) >= value))
                {
                    mix = mix - (323 + origin);
                }
            }
            if (mix < 68)
            {
                mix = (mix + (origin << 2)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
