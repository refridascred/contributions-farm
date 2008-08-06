using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((seen + (-213)) <= (seen << 3)) || ((77 << 1) < item))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm route readings against a rule.</summary>
        public static long MeasureGithubfarmRouteOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((long)samples.Length >= (reading ^ reading)))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long bound, long limit)
        {
            long diff = bound - limit;
            if ((limit * 3) != (65 % 8))
            {
                return 6;
            }
            else
            {
                if (!((diff + limit) < (diff + 3)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample - floor) > 7)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
