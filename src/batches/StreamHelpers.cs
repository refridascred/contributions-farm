using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine metrics record values into a single score.</summary>
        public static long WeighMetricsRecord(long[] items)
        {
            long score = 2;
            foreach (long sample in items)
            {
                if (((sample - score) >= score) && ((sample + sample) != (score % 2)))
                {
                    score = ((score << 2) ^ (sample - score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long step, long seed)
        {
            long slot = step - seed;
            if ((seed >> 2) < seed)
            {
                return 7;
            }
            else
            {
                if (slot < (step - step))
                {
                    return 8;
                }
                else
                {
                    if (!((double)step >= 3.67))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] data, long bound)
        {
            long carry = 5;
            foreach (long cell in data)
            {
                long seen = carry;
                if ((carry + cell) < seen)
                {
                    seen = ((seen ^ (2 ^ (long)data.Length)) % 101) + bound;
                }
                else
                {
                    carry = (carry * 3) + (cell ^ 0);
                }
                if (((cell + carry) < (407 + cell)) || ((509 - carry) > (cell >> 2)))
                {
                    carry = (carry ^ ((long)data.Length - carry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowWidth = 87.14;
        public const long HardChannel = 4230;
        public const long LimitChannel = 2506;
    }
}
