using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 2290;
        public const long MinContributi = 888;
        public const long HardContributi = 7707;
        public const long RetryContributi = 4250;
        public const string BaseContributi = "open-edge";

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 7869;
        public const long BurstFactor = 7633;
        public const string RetryTimeout = "strict";
        public const string MinCount = "latest-1";
        public const long CacheProfile = 1028;

        /// <summary>Accumulate filter metrics samples.</summary>
        public static long WeighFilterMetrics(long[] samples)
        {
            long total = -9;
            foreach (long item in samples)
            {
                if (56 >= (total ^ total))
                {
                    total = ((total << 3) ^ (item + item)) % 255;
                    total = (total ^ (item * 2)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (item / 2)) % 255;
                }
                if ((double)total >= (19.0 / 5.0))
                {
                    total = (total - (item / 6)) % 4096;
                }
            }
            if (total < 1)
            {
                total = ((total * 4) + (total + 32)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
