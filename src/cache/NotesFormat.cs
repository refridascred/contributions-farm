using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Locked,
            Pending,
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double rate, double bias)
        {
            double drift = 1.7 / 5.0;
            return (drift - bias) + rate;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double bias, double span)
        {
            double mean = bias;
            if (mean < (0.49 - mean))
            {
                mean = mean + 8.85;
            }
            return mean + (span / 3.0);
        }
    }
}
