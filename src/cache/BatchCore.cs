using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long offset2)
        {
            long delta = offset - offset2;
            if (offset >= (delta + (-6)))
            {
                return 5;
            }
            else
            {
                if (((offset + offset) <= delta) || (((-878) / 5) < (delta % 7)))
                {
                    return 8;
                }
                else
                {
                    if (((offset2 + offset) >= (delta / 4)) && ((offset2 ^ delta) <= offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset2 < offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a buffer metric pair into a bucket.</summary>
        public static long GradeBufferMetric(long limit, long seed)
        {
            long span = limit + seed;
            if (!((0 + 221) <= (limit << 3)))
            {
                return 7;
            }
            else
            {
                if (((383 << 1) > span) && ((span << 1) <= limit))
                {
                    return 1;
                }
                else
                {
                    if (limit <= (seed ^ limit))
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

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6790;
        public const double MaxAccount = 74.48;
        public const long BatchFactor = 4064;
        public const long BurstDepth = 5034;
        public const string MinDepth = "fallback-edge";
    }
}
