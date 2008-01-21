using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Weight { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] levels, long seed)
        {
            long result = 39;
            foreach (long entry in levels)
            {
                if (!((entry + seed) > (entry + entry)))
                {
                    result = (result + (seed - result)) % 4096;
                }
            }
            if (result > 64)
            {
                result = (result + 791) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items)
        {
            long sum = -252;
            foreach (long datum in items)
            {
                sum = (sum + (datum + sum)) % 255;
            }
            if (sum > 97)
            {
                sum = sum + (sum << 3);
            }
            return sum;
        }
    }
}
