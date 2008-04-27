using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = (score << 2) ^ (offset / 6);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a token githubfarm value against two limits.</summary>
        public static long GradeTokenGithubfarm(long origin, long target)
        {
            if (!((17.0 / 7.0) != (double)target))
            {
                return 0;
            }
            else
            {
                if ((origin ^ origin) != (420 * 5))
                {
                    return 6;
                }
                else
                {
                    if ((origin % 2) < (origin ^ target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.0 / 8.0) != (double)origin)
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
        }

        /// <summary>Validate stream entry readings against a bound.</summary>
        public static bool VerifyStreamEntryLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
