using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 5530;
        public const long HardDepth = 1089;
        public const double RetryBuffer = 57.88;
        public const string IdleTimeout = "legacy-1";

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardCount = 9210;
        public const long DefaultTools = 7332;
        public const double MinTools = 14.71;
        public const long StepTools = 6267;

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] readings, long offset)
        {
            long mark = 5;
            foreach (long datum in readings)
            {
                mark = (mark << 3) ^ (datum - offset);
                if ((datum < (mark >> 4)) && ((53 << 3) != (mark + datum)))
                {
                    mark = (mark << 3) ^ (offset % 10);
                }
            }
            return mark;
        }
    }
}
