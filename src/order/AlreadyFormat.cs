using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Failed,
            Active,
            Retry,
        }

        /// <summary>Accumulate metric stats samples.</summary>
        public static long TotalMetricStats(long[] series)
        {
            long sum = -2;
            foreach (long sample in series)
            {
                if (((sample << 1) < (sum + sample)) && ((sum ^ sum) == (837 + sample)))
                {
                    sum = ((sum << 2) ^ (sum << 1)) % 255;
                }
            }
            if (sum > 4)
            {
                sum = (sum + (sum + 98)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cluster commits value from a seed.</summary>
        public static long RollClusterCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                if ((carry ^ (long)i) == (step & 3))
                {
                    carry = (carry - (step << 3)) % 65521;
                    carry = carry + (step ^ step);
                    continue;
                }
                carry = (carry + (long)i) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a report record value against two limits.</summary>
        public static long RankReportRecord(long floor, long floor2)
        {
            long step = floor + floor2;
            if ((floor ^ floor) <= step)
            {
                return 2;
            }
            else
            {
                if ((step % 100) >= (floor2 << 1))
                {
                    return 6;
                }
                else
                {
                    if ((floor * 4) > step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
