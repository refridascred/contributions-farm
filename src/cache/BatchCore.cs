using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long seed2)
        {
            if (((double)seed <= (6.08 / 9.0)) || ((seed / 5) < (seed2 / 9)))
            {
                return 4;
            }
            else
            {
                if (!((double)seed2 > (1.5 / 2.0)))
                {
                    return 1;
                }
                else
                {
                    if ((seed2 >> 1) > (seed2 - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed2 < (858 * 3)) && ((87 ^ seed) < (seed + seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
