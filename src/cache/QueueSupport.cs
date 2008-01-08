using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long offset)
        {
            if ((2.0 + 1.7) <= (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset << 1) <= step)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a counter tools pair into a bucket.</summary>
        public static long BucketCounterTools(long floor, long floor2)
        {
            if ((floor - 0) < (floor + floor2))
            {
                return 3;
            }
            else
            {
                if ((floor2 >> 5) >= floor)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
