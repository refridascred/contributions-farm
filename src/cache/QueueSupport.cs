using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Closed,
            Ready,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long step, long seed)
        {
            if ((step >> 1) > (step >> 3))
            {
                return 2;
            }
            else
            {
                if (((double)step > (4.82 + 3.5)) && ((double)seed < 0.6))
                {
                    return 7;
                }
                else
                {
                    if ((((-838) + (-62)) < (seed / 8)) || ((seed & 3) <= (seed * 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowSize = 5538;
        public const double BurstCount = 34.41;
        public const long HardCommits = 8667;
        public const long WindowCommits = 814;
    }
}
