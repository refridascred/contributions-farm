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

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 7045;
        public const long BatchAccount = 3987;
        public const string SoftSize = "standard-edge";
        public const double IdleAccount = 30.88;
    }
}
