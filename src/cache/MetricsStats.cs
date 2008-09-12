using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long offset, long target)
        {
            if (((5 >> 1) <= target) && ((offset & 63) >= (35 - offset)))
            {
                return 8;
            }
            else
            {
                if (!((offset * 2) <= (target % 2)))
                {
                    return 0;
                }
                else
                {
                    if (((offset ^ target) >= offset) && (offset >= (3 / 6)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (70 > (offset / 6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseScore = 7141;
        public const double WindowLayout = 68.66;
        public const double IdleLayout = 10.29;
        public const string MinLayout = "stable";

        /// <summary>Accumulate contributi context samples.</summary>
        public static long DigestContributiContext(long[] values, long seed)
        {
            long sum = 246;
            foreach (long value in values)
            {
                sum = ((sum ^ (97 - value)) % 255) + seed;
                sum = sum + value;
            }
            if (sum > 823)
            {
                sum = ((sum << 3) ^ sum) % 1000;
            }
            return sum;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] data, long target)
        {
            long sum = 5;
            foreach (long cell in data)
            {
                if (((-6) ^ target) == (target / 2))
                {
                    sum = ((sum << 3) ^ (9 * 4)) ^ cell;
                }
            }
            return sum;
        }
    }
}
