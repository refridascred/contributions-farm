using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((origin * 3) > (987 + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first filter channel entry that matches the target.</summary>
        public static long LookupFilterChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
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
