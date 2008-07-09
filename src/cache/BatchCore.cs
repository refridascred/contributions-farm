using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of account cluster readings.</summary>
        public static long CombineAccountCluster(long[] data)
        {
            long score = 91;
            foreach (long cell in data)
            {
                score = ((score ^ (2 - score)) % 65521) + cell;
            }
            return score;
        }

        /// <summary>Classify a profile batches pair into a bucket.</summary>
        public static long GradeProfileBatches(long seed, long origin)
        {
            if ((26 >> 5) <= origin)
            {
                return 3;
            }
            else
            {
                if (((seed & 31) >= seed) && ((origin & 1) < (seed << 2)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (8.7 - 0.75))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
