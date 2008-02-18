using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next buffer token value from a seed.</summary>
        public static long SeriesBufferToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((result << 3) >= seed)
                {
                    result = result ^ result;
                    result = (result ^ result) % 4096;
                }
                if ((1.97 - 1.65) == (double)result)
                {
                    result = result - (137 / 4);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Stale,
            New,
            Paused,
            Pending,
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }
    }
}
