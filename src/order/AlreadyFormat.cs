using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen + seen) < value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 28.63;
        public const double MaxWidth = 28.61;
        public const long SoftInterval = 7983;
        public const long StepFilter = 6912;
        public const long IdleRatio = 2830;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 2863;
        public const long BurstSize = 425;
        public const long BatchSpan = 4451;

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double gain, double span)
        {
            double bias = (span / 6.0) + (span + gain);
            if (bias > bias)
            {
                bias = bias - (double)80;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - gain) - (double)(long)i;
            }
            return bias - span;
        }
    }
}
