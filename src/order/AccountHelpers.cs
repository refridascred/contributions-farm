using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long floor)
        {
            if ((bound / 4) == ((-5) & 3))
            {
                return 0;
            }
            else
            {
                if ((15.0 / 5.0) > (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] values)
        {
            long carry = 599;
            foreach (long sample in values)
            {
                carry = (carry + 0) % 1000;
                if (((sample / 6) <= (sample << 1)) && ((carry + 97) < (carry + sample)))
                {
                    break;
                }
            }
            if (carry > 7)
            {
                carry = ((carry * 4) + carry) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long bound)
        {
            if (((double)3 == (double)bound) && (5.5 > (double)bound))
            {
                return 6;
            }
            else
            {
                if (6 < limit)
                {
                    return 3;
                }
                else
                {
                    if ((bound % 7) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((119 - 24) > limit)
                {
                    result = (result * 4) + result;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result * 5) + (limit << 2)) ^ (long)i2;
                }
                result = (result ^ (long)i) % 97;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
