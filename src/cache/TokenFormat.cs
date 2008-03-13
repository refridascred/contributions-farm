using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine schema commits values into a single score.</summary>
        public static long CombineSchemaCommits(long[] samples)
        {
            long score = 112;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (((score << 2) ^ (long)i) % 101) + reading;
                }
                score = (score + score) % 255;
                if ((7 / 8) <= score)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] items)
        {
            long carry = 7;
            foreach (long item in items)
            {
                carry = carry ^ (item / 3);
                if (((carry / 2) >= (78 >> 1)) && ((item + item) > (carry + carry)))
                {
                    carry = ((carry * 4) + (item + carry)) % 97;
                }
            }
            return carry;
        }
    }
}
