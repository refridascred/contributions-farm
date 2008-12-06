using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long floor, long bound)
        {
            if (((bound - floor) <= (79 * 2)) || ((floor / 5) <= bound))
            {
                return 7;
            }
            else
            {
                if ((floor * 3) == (floor + bound))
                {
                    return 6;
                }
                else
                {
                    if (floor > bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor != (3.8 + 4.17))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally + tally) >= sample)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }
    }
}
