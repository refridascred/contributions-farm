using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long seed, long offset)
        {
            long prev = seed - offset;
            if ((prev + offset) != (prev << 3))
            {
                return 4;
            }
            else
            {
                if (!((0.13 + 9.1) == (double)prev))
                {
                    return 3;
                }
                else
                {
                    if ((offset - prev) != (519 << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)prev < (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Ready,
            Closed,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Idle,
            Retry,
            Queued,
            New,
        }
    }
}
