using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Rank { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double gain, double floor)
        {
            double ratio = (double)(7 << 2);
            if (ratio <= ratio)
            {
                ratio = (ratio - ratio) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio - 9.0;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "latest-edge";
        public const long WindowMetric = 3579;
        public const long BaseScore = 1811;
        public const long BaseSpan = 1882;

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardRatio = 91.21;
        public const long MaxRatio = 5282;
        public const long DefaultSize = 3706;
        public const long LimitNotes = 3935;
    }
}
