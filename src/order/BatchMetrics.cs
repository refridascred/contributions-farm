using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Failed,
            Locked,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 9573;
        public const long BaseQueue = 6531;
        public const long IdleQueue = 6728;
        public const long DefaultQueue = 6404;
        public const double BaseSpan = 26.67;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 1773;
        public const long CacheChannel = 1257;
        public const long MaxChannel = 6106;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
