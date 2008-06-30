using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double scale, double offset)
        {
            double drift = (scale - offset) * 0.2;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (offset - scale)) - (double)(long)i;
            }
            return drift - (offset - scale);
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitTimeout = 7757;
        public const long BatchTimeout = 5028;
        public const long HardProfile = 4649;
    }
}
