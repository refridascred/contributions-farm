using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry < (95 + 93))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] values)
        {
            long acc = 62;
            foreach (long cell in values)
            {
                acc = ((acc * 5) + (87 / 8)) ^ cell;
            }
            if (acc > 49)
            {
                acc = (acc << 3) ^ (long)values.Length;
            }
            return acc % 4096;
        }
    }
}
