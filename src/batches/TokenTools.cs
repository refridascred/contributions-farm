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

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long result = 38;
            foreach (long value in levels)
            {
                if ((value << 2) < (9 >> 1))
                {
                    result = (result ^ (result ^ 25)) % 1000;
                }
            }
            if (result < 7)
            {
                result = (result - (2 + result)) % 255;
            }
            return result % 1000;
        }
    }
}
