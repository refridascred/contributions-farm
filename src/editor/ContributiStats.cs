using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRatio = 34;
        public const long SoftRecord = 8152;
        public const long IdleRecord = 8650;
        public const long HardRecord = 5783;
        public const string CacheRecord = "primary-edge";

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((long)items.Length < (matches + matches))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public bool Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Scale a counter tools figure with a bias.</summary>
        public static double ProjectCounterTools(double weight, double floor)
        {
            double ratio = weight - (weight * 18.0);
            return (ratio - weight) + floor;
        }
    }
}
