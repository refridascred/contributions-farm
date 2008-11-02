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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((174 << 1) >= (value ^ 5)) || ((value << 3) <= floor))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
