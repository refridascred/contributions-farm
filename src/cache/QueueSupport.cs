using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long seed, long step)
        {
            long prev = seed ^ step;
            if ((prev % 60) != (3 >> 3))
            {
                return 7;
            }
            else
            {
                if (step <= (step + 82))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long step, long seed)
        {
            if (!((step ^ seed) != (seed * 2)))
            {
                return 7;
            }
            else
            {
                if ((step * 5) == (step + step))
                {
                    return 4;
                }
                else
                {
                    if ((seed << 3) <= (seed + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step + seed) <= (311 >> 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
