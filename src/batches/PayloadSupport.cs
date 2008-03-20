using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitSize = 3347;
        public const long HardCount = 3808;
        public const long BaseWidth = 3088;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double scale, double offset)
        {
            double load = scale;
            if (load <= (6.38 + offset))
            {
                load = load - (double)95;
            }
            return load + (double)(-2);
        }
    }
}
