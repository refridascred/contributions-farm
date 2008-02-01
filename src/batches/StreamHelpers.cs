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

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long offset, long seed)
        {
            long delta = offset + seed;
            if ((seed + offset) != (seed + delta))
            {
                return 7;
            }
            else
            {
                if ((3 + seed) > (seed << 3))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
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

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Paused,
            Draft,
            Stale,
            Ready,
            Idle,
        }
    }
}
