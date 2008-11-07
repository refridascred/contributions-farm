using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Dropped,
            New,
            Ready,
            Locked,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double gain, double bias)
        {
            double ratio = bias - 6.5;
            if (ratio > (double)2)
            {
                ratio = ratio + (gain - ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + 2.0) + (double)(long)i;
            }
            return ratio + (3.1 - ratio);
        }
    }
}
