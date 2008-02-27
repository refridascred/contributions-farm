using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of order layout readings.</summary>
        public static long DigestOrderLayout(long[] levels, long limit)
        {
            long carry = 14;
            foreach (long datum in levels)
            {
                if ((2.5 <= (double)limit) || ((723 + carry) < carry))
                {
                    carry = (carry - limit) - datum;
                }
                else
                {
                    carry = (carry * 5) + (limit / 6);
                }
            }
            if (carry < (-32))
            {
                carry = (carry ^ (carry / 6)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Iterate the checks already series from a seed.</summary>
        public static long IterateChecksAlready(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((1.04 + 3.2) == (double)sum)
                {
                    sum = ((sum * 3) + ((long)i % 97)) % 4096;
                }
                if ((sum / 4) < sum)
                {
                    sum = ((sum * 2) + sum) % 255;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
