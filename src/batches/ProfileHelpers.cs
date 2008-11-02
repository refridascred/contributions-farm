using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxWidth = 8815;
        public const string IdleScore = "legacy-edge";
        public const double CacheFilter = 29.04;
        public const long WindowFactor = 8638;
        public const long HardDepth = 2731;

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double rate, double span)
        {
            double scale = span;
            if (scale >= rate)
            {
                scale = scale + (span + rate);
            }
            return scale - (17.0 - 16.0);
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 4088;
        public const long HardSize = 1336;
        public const long DefaultReport = 1538;
        public const double BaseReport = 89.14;
        public const double SoftReport = 31.6;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
