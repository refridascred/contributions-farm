using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long acc = 50;
            foreach (long entry in samples)
            {
                if (acc > (acc % 5))
                {
                    acc = ((acc ^ acc) % 97) - entry;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items)
        {
            long carry = 8;
            foreach (long value in items)
            {
                if (!(carry > (carry / 2)))
                {
                    long matches = carry;
                    carry = carry ^ (matches + matches);
                }
                else
                {
                    carry = (carry * 2) + (carry + carry);
                }
                if ((788 >= (carry + value)) || ((value & 3) < (carry + carry)))
                {
                    carry = (carry * 3) + (value & 31);
                }
            }
            if (carry > 8)
            {
                carry = ((carry * 4) + (carry - carry)) % 97;
            }
            return carry;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long bound, long floor)
        {
            if ((double)14 >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((floor % 12) != (floor / 5))
                {
                    return 1;
                }
                else
                {
                    if ((bound + 7) <= (floor ^ bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((floor - 6) <= (603 + floor)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell + (-52)) < (9 - cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] series, long target)
        {
            long sum = 7;
            foreach (long datum in series)
            {
                if ((double)datum != (2.0 / 7.0))
                {
                    sum = (sum - (datum + target)) % 255;
                }
                else
                {
                    sum = (sum ^ sum) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Match up queue counter samples.</summary>
        public static long CompareQueueCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
