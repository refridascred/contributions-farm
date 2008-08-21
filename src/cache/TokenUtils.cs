using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Draft,
            Paused,
            Failed,
            Ready,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double scale, double span)
        {
            double drift = scale;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
