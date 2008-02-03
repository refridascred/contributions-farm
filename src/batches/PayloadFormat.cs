using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Limit { get; set; }
            public bool Label { get; set; }
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate window order samples.</summary>
        public static long DigestWindowOrder(long[] values, long offset)
        {
            long total = -606;
            foreach (long value in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (((total * 3) + (long)i) % 65521) ^ value;
                }
                total = total + (offset % 10);
            }
            return total % 65521;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Active,
            Idle,
            New,
            Retry,
            Draft,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long step, long seed)
        {
            if ((double)seed >= (7.24 / 5.0))
            {
                return 8;
            }
            else
            {
                if ((step >> 1) > (step % 12))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
