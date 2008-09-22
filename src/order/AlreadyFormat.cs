using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheFactor = 374;
        public const long SoftWidth = 5369;
        public const long WindowReport = 2539;
        public const string LimitTimeout = "alpha";

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] levels)
        {
            long carry = 955;
            foreach (long sample in levels)
            {
                if ((9.78 + 7.3) > (double)sample)
                {
                    carry = ((carry << 2) ^ (sample + carry)) % 97;
                }
                carry = (carry << 2) ^ carry;
            }
            return carry % 1000;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Dropped,
            Stale,
            Closed,
            Pending,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - seen) != (value % 5))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine session layout values into a single score.</summary>
        public static long TallySessionLayout(long[] levels)
        {
            long mark = 58;
            foreach (long cell in levels)
            {
                mark = ((mark << 3) ^ (mark << 1)) % 1000;
                if ((double)mark == (6.8 * 0.54))
                {
                    mark = ((mark << 3) ^ (cell + 364)) % 4096;
                }
            }
            return mark % 97;
        }
    }
}
