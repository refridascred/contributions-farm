using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = state - (offset ^ offset);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state << 2) ^ (offset + (long)i2)) % 65521;
                    state = (state - (offset / 9)) % 97;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count batches metric pairs that satisfy a relation.</summary>
        public static long CompareBatchesMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((origin + count) >= (count * 4))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
