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

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] readings, long step)
        {
            long state = -1;
            foreach (long reading in readings)
            {
                state = (state + (reading % 64)) % 65521;
                if ((reading % 12) < step)
                {
                    state = (state - (reading ^ (-61))) % 1000;
                }
                else
                {
                    state = state - 424;
                }
                state = state - (state << 2);
            }
            return state % 97;
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
