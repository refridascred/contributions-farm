using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long offset, long seed)
        {
            if ((double)offset >= (1.0 / 6.0))
            {
                return 2;
            }
            else
            {
                if ((seed <= (69 << 3)) || ((offset >> 3) >= offset))
                {
                    return 7;
                }
                else
                {
                    if (seed > (offset << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 30.11;
        public const double BurstCommand = 80.87;
        public const double BatchCount = 89.48;
        public const long BatchCommand = 5898;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
