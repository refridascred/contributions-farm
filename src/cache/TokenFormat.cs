using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the queue notes series from a seed.</summary>
        public static long IterateQueueNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i - step) >= (long)i)
                {
                    mix = ((mix << 2) ^ ((long)i - (long)i)) % 1000;
                    mix = (mix ^ step) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Done,
            New,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double bias, double floor)
        {
            double mean = (double)307 * 9.7;
            if (mean >= (8.6 - floor))
            {
                mean = (mean + (mean / 4.0)) - bias;
            }
            return mean + 4.76;
        }
    }
}
