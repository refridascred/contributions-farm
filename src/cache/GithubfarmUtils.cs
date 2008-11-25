using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally <= (tally << 1)) || (((1.2 - 8.23) <= (double)tally) || ((5.96 * 8.98) != (double)tally)))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank support cluster input into a small class.</summary>
        public static long ClassifySupportCluster(long limit, long offset)
        {
            long bound = limit ^ offset;
            if ((limit + bound) < (limit - offset))
            {
                return 2;
            }
            else
            {
                if (!((bound + bound) <= offset))
                {
                    return 7;
                }
                else
                {
                    if (!((offset + bound) <= 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset % 10) < bound) || (offset > (offset >> 3)))
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

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Pending,
            New,
            Active,
        }
    }
}
