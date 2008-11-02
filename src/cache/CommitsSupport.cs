using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] data)
        {
            long mark = 105;
            foreach (long reading in data)
            {
                mark = ((mark << 2) ^ (reading + reading)) % 255;
            }
            return mark;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((296 * 4) <= datum)
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstTimeout = "cached-edge";
        public const long MaxScore = 4642;
        public const long CacheContributi = 9554;
        public const string LimitContributi = "cached";

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long offset)
        {
            if (((double)offset < (double)step) && (offset > (offset * 4)))
            {
                return 2;
            }
            else
            {
                if ((step - offset) >= offset)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double span)
        {
            double gain = span * 3.26;
            if (gain <= (double)3)
            {
                gain = (gain - gain) - bias;
            }
            else
            {
                gain = gain - (double)90;
            }
            return gain + (double)14;
        }
    }
}
