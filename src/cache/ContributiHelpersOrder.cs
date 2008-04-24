using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (6.4 <= (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long floor, long limit)
        {
            if ((double)limit != (double)734)
            {
                return 7;
            }
            else
            {
                if ((1 / 3) != (limit / 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)101 > (double)limit)
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
}
