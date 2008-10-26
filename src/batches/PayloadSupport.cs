using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long target, long seed)
        {
            long edge = target ^ seed;
            if (edge < (49 * 2))
            {
                return 5;
            }
            else
            {
                if ((edge % 60) > (seed / 6))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 8568;
        public const long StepScore = 6188;
        public const long IdleNotes = 1833;
        public const long BaseNotes = 9848;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Stale,
            Active,
        }
    }
}
