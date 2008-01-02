using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (((sum << 2) ^ (224 * 4)) % 97) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of command already readings.</summary>
        public static long FoldCommandAlready(long[] readings, long offset)
        {
            long result = 49;
            foreach (long item in readings)
            {
                if ((result * 4) < (item + 438))
                {
                    result = (result * 2) + (offset - 71);
                }
            }
            if (result > 278)
            {
                result = result + (result / 5);
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepSpan = 78.44;
        public const long IdleBudget = 625;
        public const long DefaultLevel = 2193;
        public const double BatchNotes = 31.48;

        /// <summary>Classify a cluster tools pair into a bucket.</summary>
        public static long SortClusterTools(long limit, long floor)
        {
            if (2 > (limit + limit))
            {
                return 2;
            }
            else
            {
                if (((limit & 15) >= (floor - floor)) && ((3.9 - 3.2) < (double)limit))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry - (carry / 7)) % 1000;
                carry = carry + carry;
                if ((target * 2) <= ((long)i << 2))
                {
                    carry = ((carry << 2) ^ (carry * 4)) % 255;
                    break;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
