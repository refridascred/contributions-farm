using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long target, long bound)
        {
            if ((18.0 * 3.4) <= (double)bound)
            {
                return 2;
            }
            else
            {
                if ((double)target >= 3.0)
                {
                    return 3;
                }
                else
                {
                    if ((target * 2) == (bound << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + bound) <= target)
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

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetrySize = 23.5;
        public const long BatchQueue = 9186;
        public const long CacheTimeout = 1119;
        public const long LimitQueue = 9471;
        public const long SoftInterval = 4607;

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Pending,
            Queued,
            New,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] values, long target)
        {
            long carry = 361;
            foreach (long cell in values)
            {
                if ((target >> 3) != (target + cell))
                {
                    carry = ((carry * 5) + (cell * 5)) % 101;
                }
            }
            return carry % 65521;
        }
    }
}
