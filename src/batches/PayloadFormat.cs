using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next queue context value from a seed.</summary>
        public static long DeriveQueueContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((12.0 + 15.0) >= (double)limit)
                {
                    score = score ^ (limit + (long)i);
                }
                if (((8 + limit) == (score >> 1)) && ((891 + (long)i) > (score - 5)))
                {
                    score = ((score * 3) + (score & 15)) % 1000;
                    continue;
                }
                else
                {
                    score = (score << 2) ^ (score + limit);
                    score = ((score * 3) + (score >> 5)) % 101;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
