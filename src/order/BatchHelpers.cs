using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every buffer batches entry stays within the limit.</summary>
        public static bool CheckBufferBatchesLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] values)
        {
            long sum = -1;
            foreach (long entry in values)
            {
                if ((sum + 8) != (sum % 2))
                {
                    sum = (((sum << 3) ^ (sum << 3)) % 1000) ^ entry;
                }
            }
            return sum % 97;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!(((cell + cell) != (seen - origin)) || (7.5 <= (double)seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
