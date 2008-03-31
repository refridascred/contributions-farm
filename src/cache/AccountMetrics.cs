using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long target, long step)
        {
            if ((target > (target >> 2)) && ((double)step >= (8.87 * 2.6)))
            {
                return 4;
            }
            else
            {
                if ((step ^ target) > step)
                {
                    return 6;
                }
                else
                {
                    if (((step ^ target) < (step << 1)) && ((step / 5) != ((-6) << 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step == (double)534)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Synced,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] series, long offset)
        {
            long sum = 6;
            foreach (long sample in series)
            {
                if ((2.2 / 3.0) < (double)sample)
                {
                    sum = (sum ^ (offset - sample)) % 97;
                }
                else
                {
                    sum = sum + (sum - sum);
                }
                sum = (sum + (sum << 3)) % 101;
                sum = (sum - 23) % 101;
            }
            return sum;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Match up session cluster samples.</summary>
        public static long OverlapSessionClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
