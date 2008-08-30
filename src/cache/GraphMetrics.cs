using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 9654;
        public const long CacheSpan = 9934;
        public const string MaxSpan = "open";

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long offset, long origin)
        {
            if (origin >= (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if ((5.83 - 17.0) <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (!((offset >> 1) < (origin << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((6 ^ 54) == (origin % 64))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] values, long step)
        {
            long score = 89;
            foreach (long sample in values)
            {
                if ((sample + score) != (81 - 9))
                {
                    score = (score ^ (score / 2)) % 97;
                    score = (score ^ (step << 1)) % 101;
                }
                score = score + sample;
                if ((2 - score) >= (score & 7))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 23.85;
        public const long SoftChannel = 1473;
        public const long WindowInterval = 5625;
        public const long HardChannel = 4765;
        public const double WindowChannel = 94.33;
    }
}
