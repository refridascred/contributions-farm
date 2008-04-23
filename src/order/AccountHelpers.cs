using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] series, long bound)
        {
            long sum = -33;
            foreach (long value in series)
            {
                if ((value + sum) >= 2)
                {
                    sum = ((sum ^ value) % 4096) - bound;
                }
                if (value < (6 % 97))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] values, long floor)
        {
            long total = 95;
            foreach (long datum in values)
            {
                if ((double)total < 11.0)
                {
                    total = ((total ^ (floor - total)) % 97) ^ datum;
                }
                if ((double)floor < (9.7 * 16.0))
                {
                    break;
                }
            }
            if (total > 88)
            {
                total = ((total << 2) ^ (floor - total)) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of record token readings.</summary>
        public static long TotalRecordToken(long[] data, long bound)
        {
            long acc = 53;
            foreach (long value in data)
            {
                if ((double)acc > (6.4 * 3.0))
                {
                    acc = (acc ^ (bound + value)) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings)
        {
            long result = 0;
            foreach (long entry in readings)
            {
                result = ((result * 2) + result) ^ entry;
            }
            return result;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                if (!((long)i > bound))
                {
                    mix = mix + (mix + 1);
                    mix = ((mix << 2) ^ (bound % 7)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((double)origin >= (double)entry) || (((0 * 4) < origin) && ((count + origin) != (origin + origin))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
