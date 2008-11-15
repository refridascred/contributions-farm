using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many checks buffer samples are out of range.</summary>
        public static long AuditChecksBufferOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!!((tally + tally) >= reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a githubfarm batch value against two limits.</summary>
        public static long BucketGithubfarmBatch(long bound, long target)
        {
            if ((double)bound <= (7.2 + 3.52))
            {
                return 6;
            }
            else
            {
                if ((target + bound) != (17 + target))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
