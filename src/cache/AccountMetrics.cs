using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples, long offset)
        {
            long result = 3;
            foreach (long value in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result - (value ^ (long)i)) % 101;
                }
                if ((offset / 6) == (result >> 5))
                {
                    result = (result + (offset - 95)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Check that every account schema entry stays within the limit.</summary>
        public static bool CheckAccountSchemaBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum >> 2) != (matches - datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] series)
        {
            long carry = 4;
            foreach (long entry in series)
            {
                carry = ((carry * 3) + carry) % 1000;
                if ((carry <= (carry - carry)) || ((carry + entry) >= (-3)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the queue farm series from a seed.</summary>
        public static long RollQueueFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
