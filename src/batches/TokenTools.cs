using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor * 3) + (long)i2) % 97;
                }
                anchor = anchor + (656 / 4);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] series)
        {
            long carry = 11;
            foreach (long entry in series)
            {
                carry = (carry + (carry - entry)) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = (score ^ (score % 60)) % 101;
                if ((long)i > (seed ^ seed))
                {
                    score = (score - (seed - seed)) % 1000;
                }
                else
                {
                    score = (score - (seed >> 4)) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
