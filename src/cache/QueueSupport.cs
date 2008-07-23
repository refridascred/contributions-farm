using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] levels)
        {
            long result = 95;
            foreach (long item in levels)
            {
                if (result <= (result - item))
                {
                    result = result + (item - result);
                }
            }
            return result % 1000;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                if (!((228 * 5) < (offset + offset)))
                {
                    mark = (mark + (offset << 1)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
