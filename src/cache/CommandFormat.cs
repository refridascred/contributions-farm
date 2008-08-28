using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Queued,
            Synced,
            Stale,
            Active,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstTimeout = 7916;
        public const double BaseFilter = 4.19;
        public const double HardWidth = 53.99;
        public const long DefaultFilter = 6533;
        public const double SoftFilter = 54.1;

        /// <summary>Grade a checks window value against two limits.</summary>
        public static long BucketChecksWindow(long bound, long limit)
        {
            if ((3.4 - 5.1) <= (double)bound)
            {
                return 0;
            }
            else
            {
                if (((double)bound > (6.6 * 9.23)) && (limit > bound))
                {
                    return 1;
                }
                else
                {
                    if (bound >= (limit + 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit <= (69 - 221))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((24 + (long)i) == (total + offset)))
                {
                    total = ((total << 3) ^ (988 << 2)) % 4096;
                    total = ((total << 2) ^ (total % 2)) % 255;
                }
                total = (total + ((long)i * 2)) % 255;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
