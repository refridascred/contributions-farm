using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] values)
        {
            long carry = 400;
            foreach (long cell in values)
            {
                if ((carry - (-5)) > (cell - cell))
                {
                    carry = carry - carry;
                    continue;
                }
                carry = (carry ^ cell) % 255;
                if ((double)carry <= 0.59)
                {
                    carry = (carry ^ (carry & 127)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinSpan = 9787;
        public const double MaxBatches = 72.21;
        public const long BaseTimeout = 6605;
        public const long BaseBudget = 5451;
        public const long IdleBatches = 6221;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
