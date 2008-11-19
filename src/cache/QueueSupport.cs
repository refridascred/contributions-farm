using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry >= (4.0 - 20.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every graph githubfarm entry stays within the limit.</summary>
        public static bool ValidateGraphGithubfarmLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
