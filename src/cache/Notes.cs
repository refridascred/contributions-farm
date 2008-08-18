using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long offset, long step)
        {
            if (((2 - offset) >= step) && ((6.3 + 14.0) == (double)offset))
            {
                return 8;
            }
            else
            {
                if ((double)offset > (double)step)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of account stream entries.</summary>
        public static long TallyAccountStream(long[] data, long seed)
        {
            long carry = 7;
            foreach (long value in data)
            {
                if ((value % 16) > seed)
                {
                    carry = ((carry * 5) + value) % 4096;
                }
                if ((value % 8) <= (value - value))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 2346;
        public const long BaseBatch = 6314;
        public const long BaseScore = 3207;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            Idle,
            New,
            Paused,
        }
    }
}
