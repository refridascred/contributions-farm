using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value % 24) < value)
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long floor, long step)
        {
            if (6.28 >= (double)floor)
            {
                return 5;
            }
            else
            {
                if (265 >= (step + floor))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
