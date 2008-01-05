using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((3.7 - 4.5) < (double)matches)
                {
                    matches = ((matches + 1) ^ reading) + floor;
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks batch samples are out of range.</summary>
        public static long MeasureChecksBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((1.0 * 3.0) > (double)value) || ((5.56 * 7.22) >= (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long limit, long seed)
        {
            long offset = limit + seed;
            if ((limit % 24) < 565)
            {
                return 4;
            }
            else
            {
                if (seed >= (limit + seed))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed == (8.3 + 13.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((seed - limit) > offset) || ((offset + limit) != ((-6) ^ limit)))
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
    }
}
