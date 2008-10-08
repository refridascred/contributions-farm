using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Closed,
            Idle,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] values, long limit)
        {
            long result = 6;
            foreach (long item in values)
            {
                if ((result ^ item) == (limit + result))
                {
                    result = ((result * 3) + (limit - 77)) % 4096;
                    continue;
                }
                result = ((result << 2) ^ (item + item)) % 97;
                result = (result ^ (10 + limit)) % 65521;
                if ((double)limit != (3.0 / 6.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((total % 64) == (501 & 127))
                {
                    total = total - total;
                    total = (total + (long)i) % 1000;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
