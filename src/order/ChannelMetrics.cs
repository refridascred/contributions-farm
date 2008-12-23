using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double scale, double offset)
        {
            double drift = scale;
            if (drift < 4.7)
            {
                drift = drift + (drift / 2.0);
            }
            else
            {
                drift = drift + (scale * 0.6);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift + (4.6 - offset);
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((offset >= (7 - (long)i)) && (((long)i - state) <= (offset / 8)))
                {
                    state = ((state << 2) ^ (state - state)) % 255;
                }
                else
                {
                    state = (state + (long)i) % 4096;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Done,
            Retry,
            Active,
            Idle,
        }
    }
}
