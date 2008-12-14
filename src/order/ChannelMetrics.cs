using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] readings, long step)
        {
            long carry = 4;
            foreach (long item in readings)
            {
                if ((carry << 1) <= step)
                {
                    carry = ((carry << 2) ^ (step + carry)) % 4096;
                }
                else
                {
                    carry = (carry + item) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale - gain)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Dropped,
            Retry,
        }
    }
}
