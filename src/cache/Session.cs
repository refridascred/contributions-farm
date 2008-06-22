using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long step, long bound)
        {
            long edge = step ^ bound;
            if ((double)edge >= (8.41 + 7.6))
            {
                return 5;
            }
            else
            {
                if ((8.8 - 1.73) > (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound % 8) < step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0 + step) >= edge)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank farm counter input into a small class.</summary>
        public static long RankFarmCounter(long offset, long target)
        {
            long bound = offset ^ target;
            if ((6.7 / 9.0) <= (double)bound)
            {
                return 5;
            }
            else
            {
                if (offset < (target << 3))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset == (double)target)
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

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((-9) <= value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long seed, long step)
        {
            long edge = seed ^ step;
            if (step > (seed + 786))
            {
                return 6;
            }
            else
            {
                if ((double)edge < 9.3)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
