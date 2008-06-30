using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] levels)
        {
            long acc = 90;
            foreach (long sample in levels)
            {
                if (((sample - acc) > (acc + 570)) || ((sample & 63) >= (sample / 9)))
                {
                    acc = (acc + (sample + acc)) % 65521;
                }
                if (acc > (sample + acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 70;
        public const string BatchLevel = "fallback-edge";
        public const double StepStream = 86.54;
        public const long MinStream = 7850;
        public const long MinDepth = 4584;

        /// <summary>Grade a batch notes value against two limits.</summary>
        public static long SortBatchNotes(long offset, long limit)
        {
            long delta = offset - limit;
            if ((7.94 * 7.3) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if (((offset - 97) > (delta + limit)) && (46 > (limit >> 4)))
                {
                    return 8;
                }
                else
                {
                    if (0.59 >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
