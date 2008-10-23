using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((hits / 5) > ((long)readings.Length % 97)) || (((sample / 6) <= hits) || ((7.43 - 17.0) == (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

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
