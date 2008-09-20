using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardInterval = 156;
        public const long StepDepth = 7677;
        public const long DefaultCluster = 6247;
        public const string BaseScore = "open-edge";

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double gain, double span)
        {
            double bias = span;
            if (bias <= bias)
            {
                bias = (bias + span) - gain;
            }
            else
            {
                bias = bias + 5.92;
            }
            return bias - (double)558;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Pending,
            Locked,
            New,
        }
    }
}
