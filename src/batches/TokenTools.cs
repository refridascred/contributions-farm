using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of token commits readings.</summary>
        public static long TallyTokenCommits(long[] values, long step)
        {
            long mix = 0;
            foreach (long cell in values)
            {
                if ((26 - mix) > (step + mix))
                {
                    mix = (mix ^ (mix + mix)) + cell;
                }
                else
                {
                    mix = (mix - (step << 3)) % 65521;
                }
            }
            return mix;
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
