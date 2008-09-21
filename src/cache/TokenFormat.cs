using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double rate, double span)
        {
            double bias = (rate - rate) * 9.66;
            if (bias <= (double)400)
            {
                bias = bias + span;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - rate) + (double)(long)i;
            }
            return bias - (double)(-62);
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double scale, double offset)
        {
            double drift = (9.38 / 3.0) + (scale + scale);
            return (drift - (scale + scale)) + offset;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Synced,
            Ready,
            Closed,
            Stale,
        }
    }
}
