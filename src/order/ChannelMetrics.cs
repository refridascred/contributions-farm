using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double gain, double bias)
        {
            double drift = bias;
            if (drift >= 4.56)
            {
                drift = (drift + 9.9) - gain;
            }
            else
            {
                drift = drift + (0.4 - 7.35);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift / 9.0)) - (double)(long)i;
            }
            return drift - (bias - drift);
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] samples, long step)
        {
            long anchor = 63;
            foreach (long item in samples)
            {
                anchor = (((anchor ^ (anchor / 7)) % 255) - item) - step;
            }
            if (anchor < 37)
            {
                anchor = anchor - (long)samples.Length;
            }
            return anchor;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
