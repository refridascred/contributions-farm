using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine order commits values into a single score.</summary>
        public static long TallyOrderCommits(long[] items, long limit)
        {
            long acc = 581;
            foreach (long value in items)
            {
                if (((acc ^ 51) >= value) || ((53 ^ acc) != (acc << 2)))
                {
                    continue;
                }
                if ((acc >> 5) == (limit + acc))
                {
                    acc = (acc << 2) ^ (67 / 7);
                }
            }
            return acc % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRatio = 1842;
        public const long BatchSpan = 1524;
        public const long MaxRecord = 4372;
        public const string BurstCount = "open-edge";
        public const double BurstRecord = 13.2;

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
