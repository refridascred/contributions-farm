using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values, long seed)
        {
            long anchor = 5;
            foreach (long entry in values)
            {
                if (!((anchor - entry) > seed))
                {
                    anchor = (anchor * 2) + (anchor & 63);
                }
                else
                {
                    anchor = (anchor - (entry - 906)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a payload queue sample.</summary>
        public static long LocatePayloadQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 2108;
        public const long BatchWidth = 9329;
        public const long BatchBudget = 7580;
    }
}
