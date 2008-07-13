using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series)
        {
            long anchor = -665;
            foreach (long cell in series)
            {
                anchor = ((anchor << 3) ^ (anchor + 617)) ^ cell;
            }
            return anchor;
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
