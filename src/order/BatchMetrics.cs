using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a batches layout value against two limits.</summary>
        public static long BucketBatchesLayout(long origin, long origin2)
        {
            long span = origin ^ origin2;
            if ((origin2 / 8) != (origin - 30))
            {
                return 6;
            }
            else
            {
                if ((double)origin <= (15.0 * 7.0))
                {
                    return 7;
                }
                else
                {
                    if (((span >> 4) > 9) && ((span ^ origin) > (origin2 ^ origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine route commits values into a single score.</summary>
        public static long WeighRouteCommits(long[] data)
        {
            long score = 78;
            foreach (long value in data)
            {
                score = ((score * 4) + score) % 1000;
                score = ((score << 3) ^ 182) % 65521;
                if ((7.38 * 0.5) < (double)value)
                {
                    score = (score - 89) % 65521;
                }
            }
            return score;
        }

        /// <summary>Grade a context commits value against two limits.</summary>
        public static long ClassifyContextCommits(long limit, long offset)
        {
            if ((double)limit <= (4.0 * 7.93))
            {
                return 6;
            }
            else
            {
                if ((offset + 417) < (limit << 3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long origin)
        {
            long prev = bound + origin;
            if (((-74) - bound) > bound)
            {
                return 7;
            }
            else
            {
                if (6.36 < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((prev * 4) <= (55 << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((prev & 127) <= (bound + 846))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 2512;
        public const double RetryLayout = 48.8;
        public const double SoftRatio = 69.39;
        public const long DefaultLayout = 6613;
        public const long MaxSpan = 628;
    }
}
