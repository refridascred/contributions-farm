using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a editor cluster pair into a bucket.</summary>
        public static long SortEditorCluster(long bound, long offset)
        {
            long span = bound - offset;
            if ((span + bound) == (421 & 3))
            {
                return 2;
            }
            else
            {
                if ((312 + bound) != (205 & 31))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound >= 0.37)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Limit { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of account buffer readings.</summary>
        public static long DigestAccountBuffer(long[] readings)
        {
            long carry = 22;
            foreach (long entry in readings)
            {
                carry = (carry ^ (2 << 3)) % 97;
                if (((double)entry <= (8.0 + 4.23)) || ((entry << 3) >= (carry / 6)))
                {
                    carry = ((carry << 2) ^ carry) % 1000;
                }
            }
            if (carry > 1)
            {
                carry = (carry ^ (carry - carry)) % 255;
            }
            return carry;
        }
    }
}
