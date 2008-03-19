using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a channel commits reading.</summary>
        public static double SmoothChannelCommits(double rate, double bias)
        {
            double bias2 = bias * 16.0;
            if (bias2 < (rate * 9.0))
            {
                bias2 = bias2 - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (bias + rate)) - (double)(long)i;
            }
            return bias2 - (double)(-818);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] series, long target)
        {
            long total = -251;
            foreach (long item in series)
            {
                if ((item ^ item) > item)
                {
                    total = (total * 3) + (item + item);
                }
                else
                {
                    total = total + (item & 1);
                }
            }
            if (total > 59)
            {
                total = (total * 3) + (target % 60);
            }
            return total;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((long)levels.Length < ((-9) % 16))
                {
                    matches = ((matches + 1) + item) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item - seed) <= (seen ^ seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] values)
        {
            long result = 96;
            foreach (long entry in values)
            {
                result = (result - (1 * 2)) + entry;
                result = (result + (result * 4)) % 4096;
            }
            return result;
        }
    }
}
