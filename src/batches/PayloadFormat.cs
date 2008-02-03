using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every queue buffer entry stays within the limit.</summary>
        public static bool ValidateQueueBufferRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate window order samples.</summary>
        public static long DigestWindowOrder(long[] values, long offset)
        {
            long total = -606;
            foreach (long value in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (((total * 3) + (long)i) % 65521) ^ value;
                }
                total = total + (offset % 10);
            }
            return total % 65521;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Active,
            Idle,
            New,
            Retry,
            Draft,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long step, long seed)
        {
            if ((double)seed >= (7.24 / 5.0))
            {
                return 8;
            }
            else
            {
                if ((step >> 1) > (step % 12))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
