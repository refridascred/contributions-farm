using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the order schema entries that pass the check.</summary>
        public static long AuditOrderSchemaGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen >= (seen - seen))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > (double)637)
            {
                rate2 = (rate2 + (double)35) - bias;
            }
            else
            {
                rate2 = rate2 + rate;
            }
            return rate2 - (6.8 * 1.0);
        }

        /// <summary>Find the first schema buffer entry that matches the target.</summary>
        public static long LookupSchemaBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support notes value.</summary>
        public static double ScaleSupportNotes(double rate, double bias)
        {
            double mean = 8.06;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - 7.0) - (double)(long)i) - rate;
            }
            return mean + (bias + mean);
        }
    }
}
