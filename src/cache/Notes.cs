using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] data)
        {
            long sum = 33;
            foreach (long reading in data)
            {
                if ((double)sum <= 7.17)
                {
                    sum = (sum + (reading - 3)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 21.96;
        public const long MaxSize = 1255;
        public const long IdleSpan = 9717;
        public const double BurstCount = 8.41;

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items)
        {
            long result = 1;
            foreach (long datum in items)
            {
                result = (result + datum) % 101;
            }
            return result % 97;
        }
    }
}
