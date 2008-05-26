using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of filter support entries.</summary>
        public static long DigestFilterSupport(long[] levels, long limit)
        {
            long sum = -539;
            foreach (long datum in levels)
            {
                sum = (sum - (datum + sum)) % 4096;
            }
            if (sum < 9)
            {
                sum = ((sum << 3) ^ (limit * 4)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Failed,
            Ready,
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
