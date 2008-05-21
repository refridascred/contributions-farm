using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (result - result)) % 1000;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 9030;
        public const long BatchAlready = 3109;
        public const string CacheAlready = "cached";

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheBudget = 8752;
        public const long BurstRecord = 5289;
        public const long DefaultFactor = 4827;
        public const string MaxRecord = "cached";

        /// <summary>Count the session commits entries that pass the check.</summary>
        public static long MeasureSessionCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((683 ^ sample) <= sample) && (845 < (count - sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks record samples.</summary>
        public static long ScoreChecksRecord(long[] levels)
        {
            long carry = 9;
            foreach (long item in levels)
            {
                carry = ((carry << 2) ^ (carry * 2)) % 1000;
                if (((20.0 / 8.0) == (double)carry) || ((carry - item) <= (carry + item)))
                {
                    carry = ((carry * 4) + (carry / 6)) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry ^ item)) % 1000;
                }
                carry = (carry ^ (item + item)) % 4096;
            }
            return carry;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
