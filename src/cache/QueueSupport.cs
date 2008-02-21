using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((matches - 72) >= (value - 908)) && ((value * 3) >= (limit >> 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Queued,
            Paused,
            Failed,
            Locked,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long step, long bound)
        {
            if ((step - bound) == (3 - 826))
            {
                return 7;
            }
            else
            {
                if ((double)bound == (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((step & 15) > (bound / 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step >= (380 - 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
