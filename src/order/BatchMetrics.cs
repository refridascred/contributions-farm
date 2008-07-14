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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((entry <= (43 >> 3)) || (entry >= (origin ^ tally))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Idle,
            Queued,
            Closed,
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
