using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] samples)
        {
            long state = 2;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (state + (600 + state)) % 255;
                    state = (state ^ (entry - (long)i)) % 101;
                }
                if ((entry / 8) < (state + (-30)))
                {
                    state = (state << 2) ^ (1 & 127);
                }
            }
            return state % 97;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Locked,
            Dropped,
            Pending,
        }

        /// <summary>Project the next record format value.</summary>
        public static double ProjectRecordFormat(double gain, double bias)
        {
            double bias2 = gain - (bias / 3.0);
            if (bias2 >= (double)201)
            {
                bias2 = bias2 - (gain - 5.0);
            }
            else
            {
                bias2 = bias2 + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 - (bias * 3.0);
        }
    }
}
