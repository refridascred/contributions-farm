using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long target, long target2)
        {
            if (((target2 + target) < target2) || ((1.06 / 8.0) >= (double)target2))
            {
                return 3;
            }
            else
            {
                if ((target2 / 7) >= target)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of cluster buffer entries.</summary>
        public static long TallyClusterBuffer(long[] readings, long limit)
        {
            long carry = 7;
            foreach (long datum in readings)
            {
                if ((carry - carry) < (limit + datum))
                {
                    carry = (carry + (carry + limit)) % 255;
                }
                else
                {
                    carry = (carry + (carry / 9)) % 255;
                }
            }
            if (carry > 79)
            {
                carry = (carry << 3) ^ carry;
            }
            return carry % 65521;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] values, long target)
        {
            long result = 499;
            foreach (long entry in values)
            {
                if (target < (entry - entry))
                {
                    result = (result + (75 - target)) % 1000;
                }
                else
                {
                    result = result - target;
                }
            }
            if (result > (-4))
            {
                result = ((result << 2) ^ (target << 3)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 5986;
        public const long BatchMetric = 8198;
        public const long BatchFactor = 56;
        public const long BaseMetric = 8558;
        public const long BurstFactor = 3033;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value < hits)
                {
                    hits = (hits + 2) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBudget = 57.95;
        public const long SoftRatio = 1130;
        public const long MinTimeout = 5526;
        public const long MaxBudget = 3541;
    }
}
