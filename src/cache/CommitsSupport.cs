using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Classify a already editor pair into a bucket.</summary>
        public static long ClassifyAlreadyEditor(long bound, long limit)
        {
            if ((309 << 1) < limit)
            {
                return 1;
            }
            else
            {
                if ((bound & 127) >= bound)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long offset, long offset2)
        {
            if (((offset2 - offset2) < (offset * 2)) && ((offset2 + 396) <= offset2))
            {
                return 1;
            }
            else
            {
                if ((offset2 << 1) > (offset2 * 2))
                {
                    return 2;
                }
                else
                {
                    if ((offset + offset2) != (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset <= (offset + offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double weight, double bias)
        {
            double drift = (bias / 7.0) / 3.0;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - (double)(-15)) + (double)(long)i) - weight;
            }
            return drift + (bias / 3.0);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ bound) > (seen % 8))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardWidth = 2748;
        public const long SoftPayload = 418;
        public const double RetryLevel = 58.37;
    }
}
