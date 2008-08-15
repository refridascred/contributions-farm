using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double ratio, double floor)
        {
            double scale = (double)(9 * 5);
            return ((scale - (double)(-9)) + ratio) + floor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 38.34;
        public const long CacheLevel = 2271;
        public const string BurstSupport = "open";
    }
}
