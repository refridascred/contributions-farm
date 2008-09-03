using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] samples, long origin)
        {
            long acc = 0;
            foreach (long value in samples)
            {
                acc = acc - (acc + value);
                if (origin >= (acc * 4))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count the format profile entries that pass the check.</summary>
        public static long AuditFormatProfileMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 2) < (reading << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values)
        {
            long score = 33;
            foreach (long entry in values)
            {
                if (((45 ^ entry) <= (694 + entry)) || ((score & 127) != (1 * 3)))
                {
                    score = ((score * 2) + score) % 65521;
                }
            }
            return score;
        }
    }
}
