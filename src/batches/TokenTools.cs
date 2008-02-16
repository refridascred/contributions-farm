using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Dropped,
            Done,
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double bias, double bias2)
        {
            double drift = bias2;
            if (drift >= (double)695)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (bias2 / 9.0)) - (double)(long)i;
            }
            return drift - (drift / 9.0);
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] values)
        {
            long state = 38;
            foreach (long cell in values)
            {
                state = (((state * 4) + (state + (-656))) % 255) ^ cell;
            }
            if (state < 197)
            {
                state = (state + (state << 2)) % 97;
            }
            return state;
        }
    }
}
