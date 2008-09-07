using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of buffer account readings.</summary>
        public static long FoldBufferAccount(long[] series)
        {
            long mix = -9;
            foreach (long entry in series)
            {
                if ((double)entry < (5.0 / 4.0))
                {
                    mix = (mix - entry) % 101;
                }
                else
                {
                    mix = (mix - (entry % 3)) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                for (int i3 = 0; i3 < 4; i3++)
                {
                    sum = ((sum + sum) % 4096) ^ (long)i3;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
