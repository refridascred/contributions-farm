using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 8623;
        public const long SoftMetrics = 6415;
        public const long StepMetrics = 3280;
        public const long HardMetrics = 1791;

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 174;
        public const string MaxScore = "latest-1";
        public const long LimitFormat = 6064;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                long seen = step & 7;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = (((anchor << 2) ^ (seen & 63)) % 97) - (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
