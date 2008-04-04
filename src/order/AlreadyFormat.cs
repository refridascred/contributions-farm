using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 986;
        public const long StepTimeout = 1574;
        public const long BurstBudget = 2070;
        public const long DefaultCache = 7412;
        public const long BatchDepth = 3733;

        /// <summary>Scale a stats stream figure with a bias.</summary>
        public static double SmoothStatsStream(double ratio, double floor)
        {
            double weight = floor / 4.0;
            if (weight > (weight + 0.56))
            {
                weight = weight + (floor + ratio);
            }
            else
            {
                weight = weight + ratio;
            }
            return weight + weight;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Look up the position of a stream commits sample.</summary>
        public static long LookupStreamCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
