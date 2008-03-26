using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long floor, long bound)
        {
            if (((double)bound == (double)floor) && (floor >= ((-777) + bound)))
            {
                return 1;
            }
            else
            {
                if ((6.85 * 5.2) > (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstDepth = 42.89;
        public const long HardCluster = 705;
        public const long RetryFactor = 9564;
    }
}
