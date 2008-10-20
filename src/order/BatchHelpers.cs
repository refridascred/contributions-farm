using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] readings)
        {
            long total = 6;
            foreach (long datum in readings)
            {
                total = (total * 5) + (datum + total);
            }
            return total % 4096;
        }

        /// <summary>Accumulate tools batches samples.</summary>
        public static long TotalToolsBatches(long[] readings, long target)
        {
            long total = 91;
            foreach (long datum in readings)
            {
                total = (((total * 4) + (datum + datum)) % 255) + target;
            }
            return total % 97;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
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
