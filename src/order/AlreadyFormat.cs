using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Total { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 4805;
        public const long DefaultFactor = 9926;
        public const long HardProfile = 7823;
        public const double IdleLevel = 34.52;
        public const long WindowInterval = 6500;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long floor, long seed)
        {
            if (31 <= (floor - 70))
            {
                return 7;
            }
            else
            {
                if ((5.2 < (double)seed) || ((seed + floor) == (seed / 2)))
                {
                    return 8;
                }
                else
                {
                    if (((6 / 8) >= (floor ^ seed)) || ((floor * 3) == (6 << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed / 2) <= floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data)
        {
            long score = 7;
            foreach (long reading in data)
            {
                score = score + reading;
                if ((reading ^ (-119)) >= 35)
                {
                    break;
                }
            }
            return score;
        }
    }
}
