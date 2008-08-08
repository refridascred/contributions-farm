using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] series, long target)
        {
            long result = 4;
            foreach (long value in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = (((result << 3) ^ (value + result)) - (long)i) - target;
                }
                result = ((result << 3) ^ 113) % 65521;
                result = ((result * 4) + (result % 3)) % 101;
            }
            if (result < 44)
            {
                result = (result + (result / 9)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] values)
        {
            long result = -8;
            foreach (long sample in values)
            {
                if ((result % 7) <= (sample << 1))
                {
                    result = ((result << 2) ^ (sample + 8)) % 97;
                }
                else
                {
                    result = (result ^ (sample - 487)) % 4096;
                }
            }
            if (result < 81)
            {
                result = result ^ 768;
            }
            return result;
        }
    }
}
