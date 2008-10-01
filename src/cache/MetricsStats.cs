using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long offset, long offset2)
        {
            if (!((offset + offset) >= (offset % 10)))
            {
                return 1;
            }
            else
            {
                if ((double)offset2 == (20.0 / 5.0))
                {
                    return 0;
                }
                else
                {
                    if (((offset2 - offset2) == (offset2 + 53)) && ((offset << 1) <= (offset - offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long offset, long origin)
        {
            long step = offset - origin;
            if ((double)offset <= (7.7 / 2.0))
            {
                return 4;
            }
            else
            {
                if (step <= (offset + offset))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up order graph samples.</summary>
        public static long PairOrderGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowDepth = "standard-v2";
        public const long BatchInterval = 1569;
        public const long IdleWidth = 1161;
        public const double MaxSpan = 15.73;

        /// <summary>Digest a series of profile metrics entries.</summary>
        public static long TotalProfileMetrics(long[] series, long origin)
        {
            long sum = 305;
            foreach (long value in series)
            {
                sum = (((sum * 3) + (value ^ sum)) % 97) - origin;
            }
            return sum;
        }
    }
}
