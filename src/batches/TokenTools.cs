using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix << 2) ^ (mix << 3)) % 101;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] samples, long bound)
        {
            long total = -27;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (total ^ (sample ^ bound)) + (long)i;
                }
                if (!((bound + 8) > (82 ^ sample)))
                {
                    total = (total << 3) ^ (sample ^ 749);
                }
                else
                {
                    total = (total + (total >> 1)) % 4096;
                }
            }
            if (total > 446)
            {
                total = total - ((long)samples.Length - bound);
            }
            return total % 4096;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values, long target)
        {
            long result = 58;
            foreach (long cell in values)
            {
                if ((result + target) == (result + cell))
                {
                    result = (result - (target % 5)) % 101;
                }
            }
            return result % 97;
        }
    }
}
