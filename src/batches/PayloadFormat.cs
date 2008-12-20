using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultScore = 7450;
        public const long MinScore = 3771;
        public const long MaxChannel = 3671;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((double)offset <= (double)11) || ((double)offset < (double)result))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of graph batch readings.</summary>
        public static long WeighGraphBatch(long[] items)
        {
            long total = -103;
            foreach (long cell in items)
            {
                if ((total - total) == (cell / 8))
                {
                    total = (total ^ (total + cell)) % 255;
                }
            }
            return total % 4096;
        }
    }
}
