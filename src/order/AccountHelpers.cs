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

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                sum = sum - (1 / 8);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double gain, double offset)
        {
            double ratio = gain;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (ratio * 6.0)) + (double)(long)i) + offset;
            }
            return ratio - (double)55;
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
