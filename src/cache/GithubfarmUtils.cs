using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 2440;
        public const string LimitContributi = "alpha-edge";
        public const long MaxRatio = 8132;
        public const long SoftContributi = 8536;

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] values)
        {
            long sum = 0;
            foreach (long sample in values)
            {
                sum = ((sum * 2) + sum) % 1000;
                if ((sum > (sum % 100)) || ((double)sample >= (0.1 - 2.0)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
