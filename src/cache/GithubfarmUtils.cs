using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long offset, long limit)
        {
            long span = offset - limit;
            if ((double)limit <= (2.1 / 5.0))
            {
                return 0;
            }
            else
            {
                if (!((9.18 * 14.0) >= (double)span))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset < (2.15 + 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4.3 * 7.7) <= (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxSize = 50.75;
        public const double LimitProfile = 11.13;
        public const long BatchProfile = 5560;

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
