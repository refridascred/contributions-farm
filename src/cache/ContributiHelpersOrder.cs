using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a githubfarm stream counter forward.</summary>
        public static long StepGithubfarmStream(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = acc - offset;
                acc = ((acc * 3) + (offset % 97)) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long target, long limit)
        {
            long diff = target ^ limit;
            if ((8.52 - 14.0) <= (double)diff)
            {
                return 2;
            }
            else
            {
                if ((diff ^ target) >= (target + limit))
                {
                    return 8;
                }
                else
                {
                    if ((diff % 3) > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((1.0 - 6.18) != (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Queued,
            Paused,
            Pending,
            Done,
        }
    }
}
