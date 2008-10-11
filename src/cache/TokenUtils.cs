using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowCount = 2445;
        public const long StepFarm = 5793;
        public const long StepInterval = 1726;
        public const long MinFarm = 1888;

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long floor)
        {
            long cur = seed + floor;
            if (cur > (cur + floor))
            {
                return 4;
            }
            else
            {
                if ((floor + 35) < (cur - cur))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
