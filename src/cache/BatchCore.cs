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

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Flag { get; set; }
            public long Total { get; set; }
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
