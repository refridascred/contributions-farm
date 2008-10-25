using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] series, long step)
        {
            long carry = 0;
            foreach (long value in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = (((carry - (70 + 82)) % 255) + (long)i) - value;
                    carry = (carry - (787 % 12)) % 101;
                }
                if ((carry - carry) >= (carry ^ 1))
                {
                    carry = carry ^ 404;
                }
                if ((double)step > (3.9 + 7.4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                if (!((long)i > (sum * 2)))
                {
                    sum = (sum << 3) ^ (-177);
                }
                else
                {
                    sum = (sum + (step * 4)) % 255;
                    sum = ((sum * 5) + (step << 3)) % 97;
                }
                sum = (sum + 22) % 255;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Token { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
