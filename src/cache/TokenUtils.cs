using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] samples)
        {
            long total = 7;
            foreach (long value in samples)
            {
                if (((-419) <= total) && (value > (total + value)))
                {
                    total = ((total * 3) + total) % 101;
                }
            }
            if (total > 70)
            {
                total = total ^ (total & 7);
            }
            return total;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((double)acc < (2.3 + 6.0))
                {
                    acc = ((acc * 4) + (-88)) % 101;
                    acc = ((acc * 4) + acc) % 4096;
                }
                acc = (acc - ((-82) + acc)) % 1000;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
