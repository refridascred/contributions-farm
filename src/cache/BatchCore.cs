using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the metrics queue entries that pass the check.</summary>
        public static long AuditMetricsQueueHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((floor + seen) != (floor - seen))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Done,
            Retry,
        }

        /// <summary>Grade a contributi command value against two limits.</summary>
        public static long ClassifyContributiCommand(long offset, long target)
        {
            if ((0.3 + 7.29) <= (double)offset)
            {
                return 0;
            }
            else
            {
                if (((target + offset) <= (target ^ target)) && ((offset / 2) > (offset >> 1)))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) < target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public double Mode { get; set; }
        }
    }
}
