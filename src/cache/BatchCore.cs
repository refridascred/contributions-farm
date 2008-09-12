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

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long limit)
        {
            long diff = bound ^ limit;
            if (diff > (bound ^ diff))
            {
                return 4;
            }
            else
            {
                if ((diff - 660) == (limit >> 5))
                {
                    return 8;
                }
                else
                {
                    if ((limit % 10) <= (limit % 24))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((bound >> 1) >= limit))
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
