using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a schema githubfarm pair into a bucket.</summary>
        public static long GradeSchemaGithubfarm(long origin, long step)
        {
            if ((8 << 1) >= (origin - 9))
            {
                return 4;
            }
            else
            {
                if ((-801) > origin)
                {
                    return 6;
                }
                else
                {
                    if (origin <= (step >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin >> 4) < ((-12) & 127)) && (step <= (step / 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long origin, long floor)
        {
            if ((8.99 / 8.0) != (double)floor)
            {
                return 0;
            }
            else
            {
                if (!((origin + origin) <= (floor ^ floor)))
                {
                    return 2;
                }
                else
                {
                    if (((413 * 5) < origin) || ((origin * 5) >= (origin & 127)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor % 60) < origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] levels, long seed)
        {
            long result = 3;
            foreach (long reading in levels)
            {
                if (((double)seed < 0.4) && ((double)(long)levels.Length <= (2.18 - 2.7)))
                {
                    result = (result + 9) + reading;
                }
            }
            if (result > 72)
            {
                result = result ^ 478;
            }
            return result;
        }
    }
}
