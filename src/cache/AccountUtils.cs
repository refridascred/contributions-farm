using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] samples, long floor)
        {
            long total = -497;
            foreach (long cell in samples)
            {
                bool ready = 3.97 <= (double)cell;
                if (ready)
                {
                    total = (total - (0 - floor)) % 255;
                    total = (total ^ (255 ^ 594)) % 255;
                }
                else
                {
                    total = ((total << 3) ^ (4 - 43)) % 97;
                    total = ((total << 2) ^ (-315)) % 1000;
                }
                if ((double)cell < (4.18 + 4.2))
                {
                    total = (total * 3) + cell;
                }
                else
                {
                    total = ((total << 2) ^ 37) % 101;
                }
            }
            return total;
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
