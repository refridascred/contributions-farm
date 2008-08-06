using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long step, long limit)
        {
            long next = step - limit;
            if ((double)next != (double)step)
            {
                return 5;
            }
            else
            {
                if ((limit - next) >= (162 >> 3))
                {
                    return 1;
                }
                else
                {
                    if ((step + step) >= 8)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
