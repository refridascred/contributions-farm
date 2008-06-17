using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings, long origin)
        {
            long acc = 0;
            foreach (long cell in readings)
            {
                if (((double)origin >= (9.62 * 3.0)) && ((double)origin <= (9.91 + 1.8)))
                {
                    acc = (acc ^ (acc << 3)) ^ cell;
                }
                else
                {
                    acc = acc - (acc * 2);
                }
                if (((15 << 3) > (9 + (long)readings.Length)) && ((origin << 1) == (1 << 2)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of session payload entries.</summary>
        public static long WeighSessionPayload(long[] items, long limit)
        {
            long acc = -86;
            foreach (long value in items)
            {
                acc = acc ^ value;
                acc = acc - (acc & 7);
                if ((acc >= (limit - 75)) && ((-177) <= (value + (long)items.Length)))
                {
                    acc = ((acc * 3) + acc) % 101;
                }
                else
                {
                    acc = ((acc * 4) + value) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardBudget = "alpha-edge";
        public const long BurstTimeout = 3961;
        public const double LimitFormat = 31.9;
    }
}
