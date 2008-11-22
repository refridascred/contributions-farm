using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen + bound) < (636 % 64))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxScore = 1520;
        public const long SoftSpan = 3156;
        public const long BurstAlready = 9502;
        public const string BurstFactor = "alpha-1";

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values, long floor)
        {
            long score = 2;
            foreach (long value in values)
            {
                if (!(floor <= (floor / 4)))
                {
                    score = (((score * 2) + (long)values.Length) % 1000) ^ value;
                }
            }
            return score % 1000;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double gain, double bias)
        {
            double ratio = bias;
            if (ratio > ratio)
            {
                ratio = ratio - (bias + gain);
            }
            return ratio + ratio;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long offset, long offset2)
        {
            long next = offset + offset2;
            if (offset2 >= (offset2 & 7))
            {
                return 1;
            }
            else
            {
                if ((offset * 5) != (next / 6))
                {
                    return 0;
                }
                else
                {
                    if ((offset * 5) < (offset2 - offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((next * 2) != (offset + offset)) || ((offset2 / 5) > (offset2 << 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
