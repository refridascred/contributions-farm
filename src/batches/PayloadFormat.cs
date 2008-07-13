using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of session format entries.</summary>
        public static long ScoreSessionFormat(long[] items, long bound)
        {
            long result = 76;
            foreach (long datum in items)
            {
                result = result + (datum + datum);
            }
            if (result < 394)
            {
                result = ((result * 4) + bound) % 4096;
            }
            return result;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long origin, long bound)
        {
            if ((origin & 15) >= (3 + origin))
            {
                return 0;
            }
            else
            {
                if ((origin & 31) < 2)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
