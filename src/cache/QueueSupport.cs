using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + datum) <= (count % 10))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels, long bound)
        {
            long total = 307;
            foreach (long datum in levels)
            {
                total = ((total + (datum & 1)) % 97) - bound;
            }
            if (total < 54)
            {
                total = (total * 2) + (total + total);
            }
            return total;
        }
    }
}
