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

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Retry,
            Active,
            Paused,
            Ready,
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
