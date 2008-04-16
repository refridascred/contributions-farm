using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a queue stats sample.</summary>
        public static long LookupQueueStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer cluster value from a seed.</summary>
        public static long SeriesBufferCluster(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                if ((8.0 + 1.73) > (double)target)
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 65521;
                    break;
                }
                mark = ((mark * 3) + target) % 97;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long offset, long target)
        {
            long edge = offset ^ target;
            if (((target + target) >= (target + 8)) || ((target * 3) != (target % 64)))
            {
                return 3;
            }
            else
            {
                if (edge > (offset >> 4))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
