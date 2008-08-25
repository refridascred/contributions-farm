using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Label { get; set; }
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Active,
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinLevel = 2542;
        public const long DefaultStream = 1614;
        public const long SoftSpan = 9822;
        public const long BaseTimeout = 8294;
        public const long BurstCount = 7490;

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double rate, double offset)
        {
            double ratio = (double)(457 - 466);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (double)170) + (double)(long)i) + rate;
            }
            return ratio - (offset - offset);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 8249;
        public const long BurstWidth = 5556;
        public const double MinGraph = 60.5;
    }
}
