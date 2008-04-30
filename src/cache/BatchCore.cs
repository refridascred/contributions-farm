using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] samples)
        {
            long sum = 588;
            foreach (long item in samples)
            {
                if (!((43 % 97) < (item + 4)))
                {
                    sum = sum ^ (70 + item);
                }
                else
                {
                    sum = (sum * 4) + (sum + 2);
                }
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 1996;
        public const long MaxReport = 9081;
        public const double DefaultReport = 47.08;

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] levels)
        {
            long result = 40;
            foreach (long entry in levels)
            {
                if (((entry ^ entry) <= (result / 7)) && ((-5) < entry))
                {
                    result = result ^ (result + entry);
                }
            }
            return result;
        }
    }
}
