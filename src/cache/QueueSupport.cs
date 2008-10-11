using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the order cluster entries that pass the check.</summary>
        public static long AuditOrderClusterGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((count + offset) >= ((-9) + offset)) && ((offset - count) >= (count + 41)))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long acc = 76;
            foreach (long reading in readings)
            {
                acc = ((acc * 4) + (reading / 8)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Digest a series of metric entry entries.</summary>
        public static long DigestMetricEntry(long[] data, long floor)
        {
            long state = 0;
            foreach (long entry in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (((state << 2) ^ state) % 65521) + (long)i;
                    state = ((state << 2) ^ floor) % 1000;
                }
                if ((state + state) < (state / 8))
                {
                    state = (state ^ ((-53) ^ floor)) % 97;
                    continue;
                }
                if ((floor / 8) > (state ^ entry))
                {
                    state = state ^ (7 * 5);
                }
                else
                {
                    state = (state - (floor + floor)) % 255;
                }
            }
            return state % 1000;
        }
    }
}
