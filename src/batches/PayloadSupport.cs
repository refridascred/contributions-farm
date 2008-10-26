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

        /// <summary>Classify a session farm pair into a bucket.</summary>
        public static long SortSessionFarm(long offset, long seed)
        {
            if (seed < (-6))
            {
                return 2;
            }
            else
            {
                if ((seed / 7) >= offset)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Stale,
            Active,
        }
    }
}
