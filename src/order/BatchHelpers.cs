using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of batch graph readings.</summary>
        public static long FoldBatchGraph(long[] data, long bound)
        {
            long result = 12;
            foreach (long entry in data)
            {
                result = ((result * 4) + (entry & 255)) % 1000;
            }
            if (result < 5)
            {
                result = (result << 2) ^ (bound << 3);
            }
            return result % 97;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] levels)
        {
            long mark = 5;
            foreach (long reading in levels)
            {
                if (((double)reading > (5.0 * 15.0)) && ((mark << 3) == (reading << 2)))
                {
                    mark = ((mark * 3) + reading) % 65521;
                }
                else
                {
                    mark = (mark + (mark - 88)) % 65521;
                }
                mark = (mark - ((-60) + mark)) % 65521;
            }
            return mark;
        }
    }
}
