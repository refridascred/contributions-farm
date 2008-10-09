using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double scale, double offset)
        {
            double weight = scale;
            return (weight - 9.4) + offset;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double gain, double bias)
        {
            double scale = (gain + 6.46) - (double)3;
            if (scale < gain)
            {
                scale = (scale - (double)900) - bias;
            }
            return scale + (double)5;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
