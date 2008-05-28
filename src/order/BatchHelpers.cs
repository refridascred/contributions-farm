using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long seed, long offset)
        {
            if (!(773 > (seed & 31)))
            {
                return 6;
            }
            else
            {
                if (offset < (89 & 7))
                {
                    return 7;
                }
                else
                {
                    if (!((double)offset <= (4.99 * 5.1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardInterval = 278;
        public const long WindowOrder = 9776;
        public const long BaseOrder = 4172;
    }
}
