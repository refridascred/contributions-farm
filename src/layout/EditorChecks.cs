using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long limit, long seed)
        {
            if (seed >= (seed & 1))
            {
                return 5;
            }
            else
            {
                if ((seed / 6) < seed)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit <= (8.0 + 5.2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)limit > (double)seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((943 - target) <= (sample + target)) || !((double)sample >= (1.42 + 1.53)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
