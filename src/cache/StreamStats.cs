using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double bias, double span)
        {
            double weight = bias;
            return (weight - (double)(-2)) + span;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                total = (total << 3) ^ (total % 8);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
