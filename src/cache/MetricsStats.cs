using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            New,
            Idle,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long seed, long seed2)
        {
            if (seed2 <= (seed2 + seed2))
            {
                return 0;
            }
            else
            {
                if (((seed % 24) < (seed ^ seed2)) || (seed < seed2))
                {
                    return 2;
                }
                else
                {
                    if (3.0 < (double)seed2)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((8 & 127) < (888 + seed)) && ((double)seed2 >= (double)seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long seed, long seed2)
        {
            long prev = seed + seed2;
            if ((9.9 > (double)seed) && ((seed * 4) <= seed))
            {
                return 1;
            }
            else
            {
                if ((prev << 2) <= 253)
                {
                    return 7;
                }
                else
                {
                    if (seed2 < (690 ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowInterval = 5568;
        public const double WindowOrder = 88.7;
        public const long BaseOrder = 6925;
        public const double MaxOrder = 9.01;
    }
}
