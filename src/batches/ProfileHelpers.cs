using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a session order sample.</summary>
        public static long SeekSessionOrderIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] levels, long seed)
        {
            long mark = 4;
            foreach (long cell in levels)
            {
                mark = (((mark << 2) ^ (mark + cell)) % 1000) + seed;
            }
            return mark % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheScore = "standard-1";
        public const double WindowFarm = 41.32;
        public const long BatchScore = 3233;
        public const long HardFarm = 2519;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Draft,
            Closed,
        }
    }
}
