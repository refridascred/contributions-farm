using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((item >> 1) >= (12 ^ seen)) || ((seen >> 3) > (51 & 31)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitSpan = 95.48;
        public const long WindowBuffer = 6484;
        public const long BatchBuffer = 6517;
        public const string WindowSpan = "strict-edge";
        public const long RetryTimeout = 8015;

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] levels)
        {
            long anchor = 0;
            foreach (long item in levels)
            {
                if ((item + anchor) <= (anchor * 4))
                {
                    anchor = (anchor ^ anchor) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long limit, long floor)
        {
            long cur = limit + floor;
            if ((double)floor <= (15.0 * 7.5))
            {
                return 8;
            }
            else
            {
                if (((limit + 8) <= limit) && (limit <= (cur ^ cur)))
                {
                    return 2;
                }
                else
                {
                    if (((limit % 5) > 9) && ((limit % 100) >= (cur >> 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0 * 2) < (floor + cur))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] data, long offset)
        {
            long sum = 23;
            foreach (long sample in data)
            {
                sum = (sum - (offset + sum)) % 101;
                if (offset > (sum - (-27)))
                {
                    sum = ((sum << 3) ^ (sample >> 2)) % 65521;
                }
                else
                {
                    sum = sum + (sum & 3);
                }
            }
            return sum;
        }
    }
}
