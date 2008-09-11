using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank graph batches input into a small class.</summary>
        public static long GradeGraphBatches(long limit, long origin)
        {
            if (limit <= (limit + limit))
            {
                return 8;
            }
            else
            {
                if (!((limit >> 3) != (origin / 9)))
                {
                    return 2;
                }
                else
                {
                    if ((limit * 2) < (8 + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
