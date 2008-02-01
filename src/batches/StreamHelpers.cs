using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i % 10) != (long)i)
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long limit, long offset)
        {
            if ((offset ^ limit) > (768 ^ offset))
            {
                return 2;
            }
            else
            {
                if ((double)offset >= (8.8 * 8.19))
                {
                    return 8;
                }
                else
                {
                    if (9 > (offset % 97))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((0 / 4) < (5 - limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the token metric entries that pass the check.</summary>
        public static long TallyTokenMetricMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum >= (6.5 + 17.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] levels)
        {
            long sum = 807;
            foreach (long entry in levels)
            {
                if ((entry - entry) < (85 / 5))
                {
                    sum = ((sum * 4) + (entry + sum)) % 97;
                }
            }
            return sum;
        }
    }
}
