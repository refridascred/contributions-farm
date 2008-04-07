using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] data)
        {
            long carry = -285;
            foreach (long datum in data)
            {
                if (((carry ^ datum) < datum) || ((datum * 4) > carry))
                {
                    carry = (carry - datum) % 101;
                }
                else
                {
                    carry = ((carry * 3) + (carry << 2)) % 255;
                }
                if ((datum - carry) > (carry - (long)data.Length))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Region { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
        }
    }
}
