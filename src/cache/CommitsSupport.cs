using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] levels)
        {
            long score = 4;
            foreach (long datum in levels)
            {
                if ((score + score) != (datum - score))
                {
                    score = (score + (datum & 31)) % 97;
                }
                else
                {
                    score = ((score * 3) + (datum + 123)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long origin, long limit)
        {
            long diff = origin + limit;
            if (((-9) >> 1) < origin)
            {
                return 7;
            }
            else
            {
                if (!((double)diff >= 19.0))
                {
                    return 0;
                }
                else
                {
                    if (!((limit << 1) >= (limit + limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)diff >= (4.0 / 4.0)) || (12.0 <= (double)limit))
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

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((8.0 + 8.23) < (double)anchor)
                {
                    continue;
                }
                else
                {
                    anchor = (anchor - (floor % 7)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Look up the position of a report support sample.</summary>
        public static long LookupReportSupportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryDepth = 5277;
        public const double IdleTimeout = 70.25;
        public const string CacheBudget = "alpha";

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
