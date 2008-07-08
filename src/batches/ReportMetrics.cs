using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowTimeout = 1166;
        public const long BurstMetrics = 2892;
        public const long BaseInterval = 9837;
        public const long RetryMetrics = 4275;

        /// <summary>Accumulate route account samples.</summary>
        public static long WeighRouteAccount(long[] data, long step)
        {
            long acc = 7;
            foreach (long cell in data)
            {
                if (!((9.0 * 14.0) > (double)cell))
                {
                    acc = (acc ^ (cell & 15)) + step;
                }
            }
            if (acc < 54)
            {
                acc = ((acc << 3) ^ (49 - acc)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
