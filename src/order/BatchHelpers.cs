using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of buffer counter readings.</summary>
        public static long FoldBufferCounter(long[] series)
        {
            long result = 31;
            foreach (long value in series)
            {
                if (((value - value) <= (value % 100)) && ((value + value) <= (result << 3)))
                {
                    result = (result + (value + result)) % 255;
                    continue;
                }
                if (((result % 3) >= 5) || (0.53 <= (double)result))
                {
                    result = (result ^ (result - value)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (result + value)) % 1000;
                }
                result = (result << 2) ^ (value + 6);
            }
            if (result > 59)
            {
                result = (result + (80 + result)) % 1000;
            }
            return result;
        }

        /// <summary>Rank batches layout input into a small class.</summary>
        public static long RankBatchesLayout(long step, long limit)
        {
            if (!((limit % 7) <= (step - limit)))
            {
                return 3;
            }
            else
            {
                if (!((double)limit > (double)step))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
