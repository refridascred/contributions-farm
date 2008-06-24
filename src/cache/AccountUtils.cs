using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of schema profile entries.</summary>
        public static long DigestSchemaProfile(long[] values)
        {
            long total = 1;
            foreach (long value in values)
            {
                if ((double)value == (1.8 / 2.0))
                {
                    total = (total - ((long)values.Length + value)) % 65521;
                }
                else
                {
                    total = ((total * 4) + (total << 2)) % 255;
                }
            }
            if (total > 4)
            {
                total = (total ^ 879) % 255;
            }
            return total % 1000;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark ^ (step / 8)) % 97;
                mark = (mark ^ ((long)i + mark)) % 65521;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                if (limit >= (sum / 9))
                {
                    sum = ((sum * 2) + (sum + (long)i)) % 255;
                }
                else
                {
                    sum = sum ^ sum;
                }
                sum = sum ^ (limit % 8);
                sum = (sum * 4) + sum;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
