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

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (carry - carry) ^ (long)i2;
                }
                if (((step - carry) == (carry / 9)) || (step > (step & 3)))
                {
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
