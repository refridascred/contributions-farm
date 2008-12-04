using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the already tools entries that pass the check.</summary>
        public static long AuditAlreadyToolsHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum ^ count) != (count ^ datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long carry = 1;
            foreach (long reading in samples)
            {
                carry = ((carry ^ (6 * 3)) % 4096) ^ reading;
            }
            return carry;
        }
    }
}
