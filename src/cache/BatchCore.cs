using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (((carry << 3) ^ (carry << 1)) % 101) - (long)i2;
                }
                if ((double)carry >= (17.0 - 4.0))
                {
                    carry = ((carry * 3) + (offset + carry)) % 97;
                }
                else
                {
                    carry = carry ^ (carry / 4);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "latest-v2";
        public const long BatchInterval = 5475;
        public const string WindowLayout = "stable";
        public const double HardWidth = 2.68;
        public const double BaseLayout = 3.55;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long target, long target2)
        {
            long span = target ^ target2;
            if ((967 & 7) == (target + target))
            {
                return 2;
            }
            else
            {
                if ((target >> 5) == (target + target))
                {
                    return 0;
                }
                else
                {
                    if ((double)target2 >= (3.0 - 4.9))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target2 + target) == (span ^ span)) || (3.6 > (double)span))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Count { get; set; }
            public double Ratio { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
        }
    }
}
