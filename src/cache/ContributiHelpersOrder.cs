using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Ready,
            Queued,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long limit, long seed)
        {
            long step = limit ^ seed;
            if ((7.0 / 5.0) >= (double)step)
            {
                return 8;
            }
            else
            {
                if ((limit + seed) > (seed * 2))
                {
                    return 3;
                }
                else
                {
                    if (5.72 <= (double)step)
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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long step, long offset)
        {
            long delta = step ^ offset;
            if (!((delta ^ 559) <= (offset ^ step)))
            {
                return 4;
            }
            else
            {
                if ((delta >> 1) == (offset - offset))
                {
                    return 2;
                }
                else
                {
                    if ((offset & 15) == (step ^ step))
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
