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

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
