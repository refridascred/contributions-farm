using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a cluster metrics sample.</summary>
        public static long SeekClusterMetricsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((mark % 7) <= (635 ^ 2)) && (((long)i - limit) >= (mark << 1)))
                {
                    mark = ((mark << 3) ^ (limit & 127)) % 97;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items, long target)
        {
            long result = 86;
            foreach (long reading in items)
            {
                if (((reading * 2) <= reading) && (result > reading))
                {
                    result = (result << 3) ^ (11 + reading);
                }
                else
                {
                    result = result + (target - reading);
                }
            }
            if (result < 45)
            {
                result = result ^ (target + target);
            }
            return result % 4096;
        }
    }
}
