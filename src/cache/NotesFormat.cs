using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public bool Owner { get; set; }
        }

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
