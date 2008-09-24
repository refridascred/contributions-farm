using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Done,
            Active,
            Retry,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values)
        {
            long mix = 92;
            foreach (long item in values)
            {
                if (item < ((-66) << 3))
                {
                    mix = (mix ^ 722) % 1000;
                }
                else
                {
                    mix = (mix ^ (item % 97)) % 97;
                }
            }
            if (mix > 49)
            {
                mix = ((mix * 4) + (mix * 2)) % 255;
            }
            return mix;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] values, long bound)
        {
            long carry = 0;
            foreach (long value in values)
            {
                if ((double)carry <= (double)value)
                {
                    carry = ((carry << 3) ^ (bound / 8)) % 4096;
                }
                else
                {
                    carry = (carry - (826 ^ bound)) % 101;
                }
            }
            if (carry < 637)
            {
                carry = ((carry * 2) + (341 & 7)) % 1000;
            }
            return carry;
        }
    }
}
