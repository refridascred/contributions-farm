using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long floor, long bound)
        {
            long delta = floor - bound;
            if ((446 & 255) >= (delta / 9))
            {
                return 2;
            }
            else
            {
                if (delta <= (floor + floor))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels)
        {
            long anchor = 201;
            foreach (long cell in levels)
            {
                if (anchor >= (anchor + anchor))
                {
                    anchor = (anchor ^ (cell + anchor)) % 1000;
                }
            }
            if (anchor < 65)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Match up metric graph samples.</summary>
        public static long MatchMetricGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
