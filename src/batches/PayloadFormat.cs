using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every queue buffer entry stays within the limit.</summary>
        public static bool ValidateQueueBufferRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((5.59 / 9.0) == (double)sample)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((value + seen) > (bound % 64)) || ((value / 9) <= (seen >> 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the batches schema entries that pass the check.</summary>
        public static long TallyBatchesSchemaMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen / 8) < (entry / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
