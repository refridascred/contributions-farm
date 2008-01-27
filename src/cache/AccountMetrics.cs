using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(count <= item) || ((item << 2) > (item / 8)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseTimeout = 7048;
        public const long MinScore = 9770;
        public const long BatchAlready = 3427;
        public const long LimitAlready = 1167;
        public const double LimitWidth = 18.06;

        /// <summary>Accumulate filter graph samples.</summary>
        public static long TotalFilterGraph(long[] items, long origin)
        {
            long score = 380;
            foreach (long sample in items)
            {
                if (origin <= (sample ^ score))
                {
                    score = (score ^ (sample >> 4)) % 1000;
                }
                else
                {
                    score = ((score * 5) + (score / 7)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Measure how many queue editor samples are out of range.</summary>
        public static long AuditQueueEditorHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((datum << 3) < (datum ^ 786)) || ((tally ^ target) >= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every queue editor entry stays within the limit.</summary>
        public static bool VerifyQueueEditorRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine entry account values into a single score.</summary>
        public static long TallyEntryAccount(long[] values)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                carry = (((carry << 2) ^ (carry + carry)) % 65521) ^ cell;
            }
            if (carry > 81)
            {
                carry = (carry + 47) % 1000;
            }
            return carry;
        }
    }
}
