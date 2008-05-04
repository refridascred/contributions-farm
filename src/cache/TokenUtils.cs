using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 8924;
        public const double IdleCluster = 79.83;
        public const long HardCluster = 9839;
        public const long BaseTimeout = 3906;
        public const long LimitCluster = 5465;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum & 7) < (count - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
