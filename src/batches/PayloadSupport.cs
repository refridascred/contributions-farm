using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine batches layout values into a single score.</summary>
        public static long TallyBatchesLayout(long[] values, long floor)
        {
            long sum = 8;
            foreach (long datum in values)
            {
                sum = ((sum ^ sum) % 65521) + floor;
                sum = sum + (66 - datum);
                sum = (sum - (-64)) % 65521;
                if ((sum ^ sum) == ((-9) & 3))
                {
                    break;
                }
            }
            if (sum > 93)
            {
                sum = (sum ^ (sum << 1)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
