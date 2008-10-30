using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + 45) >= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token batch entries.</summary>
        public static long TallyTokenBatch(long[] levels, long seed)
        {
            long acc = 70;
            foreach (long cell in levels)
            {
                acc = (acc - seed) % 1000;
                if ((acc + 33) > (44 - acc))
                {
                    acc = (acc ^ (cell + seed)) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
