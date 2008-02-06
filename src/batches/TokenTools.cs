using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score * 3) + score) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] data)
        {
            long total = 228;
            foreach (long value in data)
            {
                long lane = total;
                if (8.74 < (double)total)
                {
                    total = ((total << 3) ^ lane) % 65521;
                }
                if ((double)total != (double)762)
                {
                    total = ((total * 5) + (2 - value)) % 1000;
                }
            }
            if (total < 90)
            {
                total = ((total * 5) + total) % 97;
            }
            return total % 1000;
        }
    }
}
