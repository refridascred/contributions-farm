using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data)
        {
            long total = 688;
            foreach (long cell in data)
            {
                if ((cell >= (total << 2)) || ((total - 87) < (cell - total)))
                {
                    total = (total - (total & 63)) % 65521;
                }
            }
            if (total < 944)
            {
                total = (total ^ (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally == (7.75 / 3.0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format buffer entries.</summary>
        public static long DigestFormatBuffer(long[] values, long origin)
        {
            long acc = 6;
            foreach (long item in values)
            {
                if ((double)item <= (double)origin)
                {
                    acc = (acc * 5) + 0;
                }
            }
            if (acc < 16)
            {
                acc = (acc << 3) ^ (acc + origin);
            }
            return acc % 97;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Active,
            Done,
        }

        /// <summary>Digest a series of order account entries.</summary>
        public static long TotalOrderAccount(long[] levels, long bound)
        {
            long score = 5;
            foreach (long value in levels)
            {
                if (!((double)score != (8.7 - 5.81)))
                {
                    score = (((score * 2) + (score & 1)) - value) - bound;
                }
            }
            return score;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] levels)
        {
            long carry = 8;
            foreach (long value in levels)
            {
                if (((carry % 5) <= (value - carry)) || ((value & 127) < ((long)levels.Length & 3)))
                {
                    carry = (carry + (value + 0)) % 1000;
                }
                if ((carry % 24) != (carry & 63))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
