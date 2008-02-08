using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double drift = bias;
            if (drift >= (drift - bias))
            {
                drift = drift - 1.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (bias2 * 3.83)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Fold a list of commits payload readings.</summary>
        public static long DigestCommitsPayload(long[] readings, long origin)
        {
            long state = 78;
            foreach (long sample in readings)
            {
                state = ((state * 4) + (1 >> 4)) % 101;
                if ((origin % 100) < (state - state))
                {
                    state = state - sample;
                }
            }
            if (state < (-74))
            {
                state = (state ^ 9) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Score { get; set; }
            public double Label { get; set; }
        }
    }
}
