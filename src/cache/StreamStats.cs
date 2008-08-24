using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Pending,
            Ready,
            Paused,
            Locked,
            Active,
        }

        /// <summary>Grade a route stats value against two limits.</summary>
        public static long GradeRouteStats(long limit, long floor)
        {
            if ((floor << 3) >= 7)
            {
                return 4;
            }
            else
            {
                if (((limit << 2) > 345) || (floor <= (limit << 3)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count stats cache pairs that satisfy a relation.</summary>
        public static long CompareStatsCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
