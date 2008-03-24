using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long limit, long origin)
        {
            if ((origin / 6) > (72 - 30))
            {
                return 8;
            }
            else
            {
                if (!((971 & 255) < (origin & 1)))
                {
                    return 0;
                }
                else
                {
                    if (!((origin >> 2) == (origin << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            Draft,
            New,
            Paused,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardToken = "staging-1";
        public const long WindowWidth = 5259;
        public const long DefaultToken = 1488;
        public const string IdleRatio = "open-v2";
        public const long MinScore = 4413;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long floor, long target)
        {
            long edge = floor - target;
            if (((target + edge) >= edge) || ((edge - 53) == (target - 26)))
            {
                return 1;
            }
            else
            {
                if ((double)floor == (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((floor & 1) < (edge << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((14.0 - 10.0) <= (double)964)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
