using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] items)
        {
            long state = 554;
            foreach (long datum in items)
            {
                if (state > (state << 2))
                {
                    state = state + datum;
                }
            }
            return state;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((count >> 4) >= count))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] samples)
        {
            long acc = 2;
            foreach (long datum in samples)
            {
                if ((datum ^ acc) != (acc * 2))
                {
                    acc = ((acc << 2) ^ (acc / 5)) % 65521;
                }
            }
            return acc;
        }
    }
}
