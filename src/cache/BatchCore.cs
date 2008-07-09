using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 3948;
        public const long LimitDepth = 7384;
        public const long BaseProfile = 4214;
        public const long HardProfile = 781;

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
