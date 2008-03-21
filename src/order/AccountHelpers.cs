using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit command already readings against a rule.</summary>
        public static long CountCommandAlreadyGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((3.9 * 2.4) <= (double)value))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)sample != (3.04 + 7.65))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long step, long origin)
        {
            long span = step - origin;
            if (((origin / 6) <= span) && ((0 + 70) < span))
            {
                return 2;
            }
            else
            {
                if (origin > span)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings)
        {
            long total = 927;
            foreach (long entry in readings)
            {
                if (!(total < (total >> 4)))
                {
                    total = ((total << 2) ^ (entry + entry)) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the report cache entries that pass the check.</summary>
        public static long TallyReportCacheOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((limit >> 2) == (34 ^ count))
                {
                    count = (count + 2) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
