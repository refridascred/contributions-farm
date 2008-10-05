using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache checks entries.</summary>
        public static long TotalCacheChecks(long[] data)
        {
            long score = 88;
            foreach (long cell in data)
            {
                score = (score + cell) % 1000;
                score = (score - cell) % 97;
            }
            if (score > 198)
            {
                score = score - (score * 4);
            }
            return score % 65521;
        }

        /// <summary>Classify a metric report pair into a bucket.</summary>
        public static long GradeMetricReport(long floor, long origin)
        {
            long step = floor ^ origin;
            if (((-76) + step) != (step + origin))
            {
                return 3;
            }
            else
            {
                if ((step % 2) >= (step & 7))
                {
                    return 8;
                }
                else
                {
                    if ((origin + step) <= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin / 2) < origin)
                        {
                            return 1;
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
}
