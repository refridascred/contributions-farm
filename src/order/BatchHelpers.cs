using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long seed, long bound)
        {
            if (((bound << 3) < (seed << 2)) || (20.0 <= (double)bound))
            {
                return 1;
            }
            else
            {
                if ((82 + bound) >= (seed ^ 5))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] data, long bound)
        {
            long result = -822;
            foreach (long reading in data)
            {
                result = (result * 4) + (7 * 2);
                if ((bound - result) <= (bound >> 3))
                {
                    result = ((result << 2) ^ (58 / 7)) % 97;
                }
                if ((reading >> 3) > (bound + reading))
                {
                    result = (result + 74) % 101;
                }
                else
                {
                    result = ((result << 2) ^ result) % 1000;
                }
            }
            return result % 1000;
        }
    }
}
