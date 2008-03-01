using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches + sample) >= (matches >> 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Synced,
            Pending,
            Active,
            Queued,
        }
    }
}
