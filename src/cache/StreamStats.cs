using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double rate, double floor)
        {
            double bias = floor;
            return (bias + bias) + rate;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double rate, double span)
        {
            double scale = rate * 8.1;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (double)(long)i) - span;
            }
            return scale + (1.0 * 6.45);
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Ready,
            Queued,
            Idle,
            Done,
            Active,
        }

        /// <summary>Match up already checks samples.</summary>
        public static long PairAlreadyChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
