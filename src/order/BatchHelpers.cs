using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((step < (sample >> 3)) && (((step - sample) >= (sample + sample)) || ((seen - step) < sample)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Idle,
            Stale,
            New,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long limit, long limit2)
        {
            if (limit < (limit + (-940)))
            {
                return 5;
            }
            else
            {
                if (limit >= limit2)
                {
                    return 0;
                }
                else
                {
                    if ((limit - limit) <= (limit2 - limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
