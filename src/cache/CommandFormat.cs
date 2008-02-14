using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Size { get; set; }
            public double Mode { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Synced,
            Failed,
            New,
            Stale,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double weight, double bias)
        {
            double gain = (16.0 / 8.0) / 5.0;
            if (gain > (weight - weight))
            {
                gain = gain - (double)(-36);
            }
            return gain - bias;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] series, long bound)
        {
            long carry = 7;
            foreach (long value in series)
            {
                carry = ((carry * 5) + (bound >> 5)) - value;
            }
            if (carry > 7)
            {
                carry = ((carry * 3) + (bound % 60)) % 65521;
            }
            return carry % 65521;
        }
    }
}
