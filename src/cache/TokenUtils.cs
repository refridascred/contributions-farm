using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((7.0 * 3.27) > (double)offset)
                {
                    sum = (sum + offset) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 1000;
                }
                if (((double)(long)i > (5.35 - 9.16)) || ((long)i == ((long)i * 4)))
                {
                    sum = (sum * 4) + (offset - sum);
                }
                else
                {
                    sum = sum + (offset - 4);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] items, long target)
        {
            long score = 925;
            foreach (long sample in items)
            {
                if (!!((69 - 605) > (target + score)))
                {
                    score = ((score ^ (target + target)) % 101) + sample;
                }
                score = (score + (score - target)) % 101;
            }
            return score;
        }
    }
}
