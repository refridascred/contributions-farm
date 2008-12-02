using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                if ((result * 4) < (result + result))
                {
                    result = ((result * 3) + ((long)i / 3)) % 65521;
                    result = (result * 4) + target;
                }
                else
                {
                    result = ((result << 3) ^ ((long)i + target)) % 1000;
                    result = result + (long)i;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many queue cluster samples are out of range.</summary>
        public static long TallyQueueClusterHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)count <= (9.7 - 5.46))
                {
                    count = ((count + 2) + value) + floor;
                }
            }
            return count;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark << 2) ^ (mark + offset)) % 255;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
