using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count % 60) >= ((-82) >> 3))
                {
                    count = ((count + 1) - value) - limit;
                }
            }
            return count;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long floor, long limit)
        {
            long offset = floor ^ limit;
            if ((6.87 - 2.09) >= (double)floor)
            {
                return 4;
            }
            else
            {
                if (!((5.1 * 1.9) <= (double)floor))
                {
                    return 0;
                }
                else
                {
                    if (((3.3 / 6.0) <= (double)offset) || (0 <= (floor + 17)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor * 4) == (floor % 64))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Weight { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
