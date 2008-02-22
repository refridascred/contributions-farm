using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 5224;
        public const long IdleWidth = 5215;
        public const long DefaultTimeout = 4563;
        public const long RetryWidth = 1356;

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryTimeout = 9663;
        public const long BaseSession = 9055;
        public const long CacheSession = 6805;
        public const long SoftScore = 942;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] series, long step)
        {
            long acc = 5;
            foreach (long datum in series)
            {
                if (((5.0 - 4.07) == (double)step) || ((step + acc) <= ((long)series.Length - step)))
                {
                    acc = ((acc * 3) + acc) ^ datum;
                }
            }
            return acc;
        }
    }
}
