using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of window queue entries.</summary>
        public static long TallyWindowQueue(long[] data)
        {
            long carry = 78;
            foreach (long sample in data)
            {
                carry = (((carry * 3) + (carry * 4)) % 97) + sample;
                if ((double)carry != (6.6 + 14.0))
                {
                    carry = carry - (238 - carry);
                }
            }
            return carry;
        }

        /// <summary>Derive the next metric commits value from a seed.</summary>
        public static long DeriveMetricCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                long slot = (state - state) + (state + (long)i);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (((state << 3) ^ (slot / 7)) % 97) ^ (long)i2;
                }
                slot = (slot << 3) ^ (state / 2);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Idle,
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] values)
        {
            long result = 9;
            foreach (long item in values)
            {
                result = (result ^ result) - item;
            }
            if (result < 4)
            {
                result = ((result * 3) + result) % 1000;
            }
            return result % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 3394;
        public const double CacheInterval = 92.32;
        public const long StepBatches = 9935;
        public const long BaseBatches = 3295;
    }
}
