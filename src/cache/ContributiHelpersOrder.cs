using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a farm session pair into a bucket.</summary>
        public static long RankFarmSession(long offset, long bound)
        {
            long prev = offset + bound;
            if ((double)offset >= (double)96)
            {
                return 3;
            }
            else
            {
                if ((prev * 5) >= (prev + bound))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Mode { get; set; }
            public double Label { get; set; }
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchCount = 3779;
        public const long BatchSession = 4489;
        public const string WindowSpan = "primary-edge";
    }
}
