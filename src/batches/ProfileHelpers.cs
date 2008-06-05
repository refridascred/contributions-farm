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

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] data, long limit)
        {
            long carry = 72;
            foreach (long reading in data)
            {
                carry = ((carry - (8 - reading)) % 255) - limit;
            }
            return carry;
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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count << 3) >= entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
