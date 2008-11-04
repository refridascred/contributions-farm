using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double gain, double bias)
        {
            double scale = (double)(-3) * 6.6;
            if (scale >= scale)
            {
                scale = (scale + (double)577) + gain;
            }
            else
            {
                scale = scale - (2.54 - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (bias + bias)) + (double)(long)i;
            }
            return scale - (bias - bias);
        }
    }
}
