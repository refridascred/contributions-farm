using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] levels, long seed)
        {
            long mark = -638;
            foreach (long item in levels)
            {
                if (item <= (item & 63))
                {
                    mark = ((mark * 3) + (seed << 3)) % 1000;
                }
                else
                {
                    mark = (mark ^ (seed * 3)) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Retry,
            Stale,
            Idle,
            Locked,
        }
    }
}
