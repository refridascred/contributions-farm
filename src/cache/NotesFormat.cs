using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double ratio, double span)
        {
            double bias = (double)(0 - 0);
            if (bias > (double)46)
            {
                bias = (bias - bias) - ratio;
            }
            else
            {
                bias = bias - (double)74;
            }
            return bias - span;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = (state + (state >> 5)) % 4096;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
