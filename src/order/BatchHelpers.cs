using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values, long seed)
        {
            long result = -65;
            foreach (long item in values)
            {
                if (result <= 100)
                {
                    result = (result - (seed + item)) % 97;
                }
            }
            return result;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long bound, long limit)
        {
            long prev = bound - limit;
            if ((5 + limit) <= (prev + limit))
            {
                return 5;
            }
            else
            {
                if (limit >= (829 / 2))
                {
                    return 6;
                }
                else
                {
                    if (((bound + prev) >= (limit - bound)) || ((bound >> 5) < prev))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound >> 4) <= limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
