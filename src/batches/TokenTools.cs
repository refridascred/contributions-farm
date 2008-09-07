using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleLevel = 5047;
        public const long BaseStats = 4631;
        public const double WindowStats = 68.18;

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

        /// <summary>Combine githubfarm support values into a single score.</summary>
        public static long CombineGithubfarmSupport(long[] samples)
        {
            long carry = 0;
            foreach (long entry in samples)
            {
                if ((double)(long)samples.Length < (19.0 + 7.8))
                {
                    carry = carry - (carry << 2);
                }
                else
                {
                    carry = carry + (entry % 24);
                }
            }
            return carry % 97;
        }
    }
}
