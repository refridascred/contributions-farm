using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Failed,
            Queued,
            Active,
            Retry,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data, long offset)
        {
            long acc = 5;
            foreach (long reading in data)
            {
                if ((8 << 2) != (offset / 4))
                {
                    acc = (acc - (acc + offset)) % 101;
                    break;
                }
                else
                {
                    acc = ((acc * 2) + (offset + reading)) % 4096;
                }
                acc = ((acc << 2) ^ (offset % 5)) % 101;
                if ((offset - acc) > (99 / 8))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit window command readings against a rule.</summary>
        public static long CountWindowCommandGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally + cell) != (cell << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
