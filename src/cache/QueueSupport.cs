using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 5782;
        public const long WindowSpan = 6857;
        public const long LimitStream = 1118;
        public const long MaxStream = 7724;
        public const long StepLevel = 6496;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Queued,
            Active,
            Stale,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long offset, long step)
        {
            if ((double)offset < (3.77 * 0.38))
            {
                return 6;
            }
            else
            {
                if ((20.0 + 1.4) == (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
