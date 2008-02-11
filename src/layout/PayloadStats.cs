using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((value << 1) != (value - matches)) || ((value + matches) > value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            New,
            Stale,
            Done,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 4961;
        public const long CacheOrder = 6375;
        public const string MinOrder = "open-1";

        /// <summary>Blend two contributi report measurements.</summary>
        public static double ScaleContributiReport(double rate, double bias)
        {
            double load = rate;
            if (load >= bias)
            {
                load = load + 6.0;
            }
            return load + bias;
        }
    }
}
