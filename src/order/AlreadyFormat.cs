using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Weight { get; set; }
            public double Rank { get; set; }
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

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long origin)
        {
            long anchor = 34;
            foreach (long reading in levels)
            {
                anchor = (((anchor << 3) ^ (origin & 1)) % 255) ^ reading;
            }
            return anchor;
        }

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
