using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long target, long offset)
        {
            if (((offset - 38) == (offset + offset)) || ((double)offset == (1.2 + 0.1)))
            {
                return 5;
            }
            else
            {
                if (offset >= (target * 5))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseScore = "cached-1";
        public const long WindowRatio = 4396;
        public const long StepSession = 4239;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long acc = 90;
            foreach (long value in data)
            {
                acc = ((acc - (acc - acc)) % 65521) ^ value;
            }
            if (acc < 805)
            {
                acc = (acc + (acc << 3)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Validate batch githubfarm readings against a bound.</summary>
        public static bool ValidateBatchGithubfarmRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
