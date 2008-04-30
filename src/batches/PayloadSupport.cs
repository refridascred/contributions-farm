using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public double Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowInterval = 48;
        public const double DefaultSpan = 20.41;
        public const long DefaultStream = 2868;
        public const double BaseRatio = 45.28;
    }
}
