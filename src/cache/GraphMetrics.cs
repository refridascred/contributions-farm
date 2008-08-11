using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate window contributi samples.</summary>
        public static long WeighWindowContributi(long[] series)
        {
            long carry = -36;
            foreach (long datum in series)
            {
                if (carry <= (799 + carry))
                {
                    carry = (carry + (carry >> 2)) - datum;
                }
                else
                {
                    carry = (carry + 454) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "strict-1";
        public const long BatchStats = 3807;
        public const long DefaultStats = 7167;
        public const long MaxStats = 5073;

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long step, long seed)
        {
            if (step > (817 + step))
            {
                return 6;
            }
            else
            {
                if ((double)step != (8.9 / 3.0))
                {
                    return 0;
                }
                else
                {
                    if (1.0 > (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
