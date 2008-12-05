using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a format counter counter forward.</summary>
        public static long RollFormatCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry ^ (356 + (long)i)) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of account command entries.</summary>
        public static long TallyAccountCommand(long[] items, long seed)
        {
            long total = 60;
            foreach (long sample in items)
            {
                total = ((total + sample) % 97) - seed;
            }
            return total % 97;
        }
    }
}
