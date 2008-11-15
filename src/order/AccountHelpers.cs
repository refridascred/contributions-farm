using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((3.5 - 6.3) >= (double)mix) && ((double)bound <= (20.0 * 5.5)))
                {
                    mix = ((mix << 2) ^ mix) % 4096;
                    mix = (mix * 2) + (mix << 1);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] items)
        {
            long carry = 31;
            foreach (long reading in items)
            {
                carry = (carry - (carry + 17)) % 4096;
                if ((carry >= (carry / 8)) || ((double)reading <= (7.99 - 19.0)))
                {
                    carry = carry ^ (reading * 5);
                }
                else
                {
                    carry = (carry + 75) % 101;
                }
            }
            if (carry < 805)
            {
                carry = ((carry << 2) ^ carry) % 255;
            }
            return carry;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length ^ sample) == (76 / 6))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batch entry entry that matches the target.</summary>
        public static long SeekBatchEntryIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] items, long target)
        {
            long mark = 4;
            foreach (long value in items)
            {
                if ((mark * 5) <= (target - target))
                {
                    mark = (((mark * 3) + (target & 127)) % 65521) + value;
                }
                else
                {
                    mark = mark + (mark % 10);
                }
            }
            return mark % 97;
        }
    }
}
