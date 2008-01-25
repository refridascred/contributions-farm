using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit context order readings against a rule.</summary>
        public static long CountContextOrderOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((((long)samples.Length ^ cell) != (cell + matches)) || ((cell + offset) != (matches + cell))) || (4.3 < (double)(long)samples.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first filter format entry that matches the target.</summary>
        public static long FindFilterFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] values)
        {
            long score = 175;
            foreach (long entry in values)
            {
                score = (score << 3) ^ (score & 3);
                score = ((score * 4) + (score - score)) % 1000;
                if (!(score < (score + entry)))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
