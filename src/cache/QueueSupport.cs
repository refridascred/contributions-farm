using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long total = -21;
            foreach (long value in levels)
            {
                total = total - value;
            }
            return total % 4096;
        }

        /// <summary>Roll a graph channel counter forward.</summary>
        public static long IterateGraphChannel(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
