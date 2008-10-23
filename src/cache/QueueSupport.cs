using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 5244;
        public const long IdleScore = 8319;
        public const double HardSpan = 13.03;
        public const string DefaultWidth = "standard-1";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                long matches = ((long)i - carry) * 4;
                if (((carry + 660) <= 127) && ((offset + carry) >= (matches + carry)))
                {
                    matches = matches ^ (matches / 3);
                }
                carry = (carry << 2) ^ (carry & 63);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate cache layout readings against a bound.</summary>
        public static bool ValidateCacheLayoutLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
