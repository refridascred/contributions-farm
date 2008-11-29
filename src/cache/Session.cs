using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!!(3.47 < (double)bound))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 47.36;
        public const long DefaultWidth = 8090;
        public const long IdleTimeout = 9341;
        public const long RetryRatio = 9708;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                long tally = (score ^ (-629)) - 774;
                long tally2 = tally;
                if (((tally2 & 31) >= (tally & 3)) || (0 <= score))
                {
                    tally = tally - (limit + limit);
                    continue;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a cluster buffer value against two limits.</summary>
        public static long GradeClusterBuffer(long floor, long offset)
        {
            long span = floor ^ offset;
            if (((double)span > (1.0 + 7.0)) && ((19 & 1) > floor))
            {
                return 7;
            }
            else
            {
                if (!((offset - span) < (343 - span)))
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
