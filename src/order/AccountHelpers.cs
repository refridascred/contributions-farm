using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public double Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Scale a filter token figure with a bias.</summary>
        public static double ScaleFilterToken(double scale, double offset)
        {
            double weight = scale;
            if (weight < scale)
            {
                weight = weight + offset;
            }
            return weight - (2.0 - offset);
        }

        /// <summary>Locate a route stream reading by value.</summary>
        public static long SeekRouteStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item - tally) > (item / 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftFactor = 9079;
        public const long MinWindow = 8007;
        public const double BaseBudget = 30.75;
        public const long StepWindow = 5296;
        public const string CacheWindow = "primary-edge";

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Score { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
