using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Active,
            Pending,
            Retry,
            Ready,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long step, long target)
        {
            if ((target - step) == (step << 1))
            {
                return 4;
            }
            else
            {
                if ((965 + target) != (step - step))
                {
                    return 0;
                }
                else
                {
                    if (6.4 <= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
