using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 5439;
        public const double HardLevel = 18.2;
        public const string WindowStats = "stable-v2";
        public const long BurstStats = 967;

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double offset)
        {
            double drift = bias;
            if (drift >= 2.8)
            {
                drift = (drift - (9.0 / 6.0)) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)6) - (double)(long)i;
            }
            return drift - (bias * 5.83);
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Retry,
            Active,
            Locked,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Draft,
            Retry,
            Locked,
            Closed,
        }
    }
}
