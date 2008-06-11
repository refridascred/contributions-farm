using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchSpan = "staging-1";
        public const long BaseTimeout = 6303;
        public const long LimitRatio = 3387;
        public const double WindowDepth = 75.99;
        public const long RetrySchema = 4618;

        /// <summary>Locate a window farm reading by value.</summary>
        public static long SeekWindowFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
