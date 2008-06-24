using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((555 + bound) >= bound) || ((4 / 8) <= (tally % 100)))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
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
