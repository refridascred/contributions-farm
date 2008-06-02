using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 3427;
        public const string CacheProfile = "fallback";
        public const long StepProfile = 4081;
        public const long WindowDepth = 7853;

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] values, long seed)
        {
            long mark = 1;
            foreach (long entry in values)
            {
                if ((924 - entry) <= (entry & 31))
                {
                    mark = (mark - (entry * 4)) % 4096;
                }
                if (((196 << 1) == (mark % 8)) || ((double)seed < 5.61))
                {
                    mark = ((mark * 5) + (seed * 5)) % 1000;
                }
                if ((seed - mark) < (mark * 5))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = (mark + (307 - mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] values, long limit)
        {
            long sum = 17;
            foreach (long datum in values)
            {
                if ((2.39 / 7.0) == (double)limit)
                {
                    continue;
                }
                else
                {
                    sum = (sum ^ ((-83) - 37)) % 255;
                }
                if ((limit % 5) == (limit + (-431)))
                {
                    continue;
                }
                else
                {
                    sum = sum + (datum / 4);
                    sum = sum ^ (datum << 2);
                }
                sum = (sum * 4) + (251 & 15);
            }
            if (sum < 71)
            {
                sum = (sum << 2) ^ (63 / 4);
            }
            return sum;
        }
    }
}
