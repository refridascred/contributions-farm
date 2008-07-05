using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double scale, double floor)
        {
            double load = (double)(191 + 34);
            for (int i = 0; i < 6; i++)
            {
                load = ((load - (load + 19.0)) + (double)(long)i) - floor;
            }
            return load + scale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "legacy-1";
        public const long BurstTimeout = 8791;
        public const long MaxCommand = 413;
        public const long RetryScore = 2966;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 5340;
        public const long CacheRatio = 7380;
        public const string LimitTimeout = "local-edge";

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
