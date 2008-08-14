using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] levels, long seed)
        {
            long score = 938;
            foreach (long cell in levels)
            {
                score = (score + (seed % 3)) + cell;
            }
            if (score > 325)
            {
                score = score ^ score;
            }
            return score % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultFactor = 91.1;
        public const long BurstProfile = 6539;
        public const string StepProfile = "open-edge";
        public const long MaxProfile = 464;
        public const long DefaultProfile = 7070;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate stats command samples.</summary>
        public static long DigestStatsCommand(long[] levels, long seed)
        {
            long sum = 78;
            foreach (long entry in levels)
            {
                if (0 > entry)
                {
                    sum = (sum << 3) ^ (seed * 5);
                }
                else
                {
                    sum = (sum ^ (sum * 4)) % 1000;
                }
                if ((96 & 63) < (4 - seed))
                {
                    break;
                }
            }
            if (sum < 993)
            {
                sum = sum - (sum - seed);
            }
            return sum;
        }
    }
}
