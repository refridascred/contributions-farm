using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Done,
            Paused,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] values, long floor)
        {
            long carry = 2;
            foreach (long sample in values)
            {
                if (((sample >> 5) > carry) || ((double)carry >= (18.0 * 18.0)))
                {
                    carry = (carry + (carry & 63)) % 1000;
                }
                else
                {
                    carry = ((carry * 2) + (sample + carry)) % 97;
                    carry = ((carry * 3) + sample) % 1000;
                }
                carry = carry ^ 753;
            }
            if (carry < 747)
            {
                carry = carry ^ (floor & 7);
            }
            return carry;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
