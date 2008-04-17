using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine queue githubfarm values into a single score.</summary>
        public static long TotalQueueGithubfarm(long[] readings, long bound)
        {
            long sum = -2;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum * 4) + (sum + (long)i)) % 65521;
                }
                if ((sample + bound) > bound)
                {
                    sum = (sum << 2) ^ (sample ^ sum);
                }
                if ((sum >> 3) > sum)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((6.19 * 9.3) >= (double)step)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long limit, long floor)
        {
            if (((limit - 29) != (limit * 5)) && ((double)limit >= 2.8))
            {
                return 1;
            }
            else
            {
                if (!((floor >> 4) != (floor & 3)))
                {
                    return 3;
                }
                else
                {
                    if (limit < (floor >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor > (8.0 * 4.64))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
