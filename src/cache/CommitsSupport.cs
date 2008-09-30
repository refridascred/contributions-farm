using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 3008;
        public const string MaxTimeout = "standard-edge";
        public const long MinSize = 9303;
        public const long BaseSize = 4438;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batches queue entry that matches the target.</summary>
        public static long FindBatchesQueueIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleSize = 8.65;
        public const long BaseRoute = 4657;
        public const long CacheBudget = 5971;

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
