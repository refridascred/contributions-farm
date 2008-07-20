using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] data)
        {
            long state = 3;
            foreach (long sample in data)
            {
                if ((state % 60) > (state + 4))
                {
                    state = (state - sample) % 97;
                }
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 32.95;
        public const double BurstRoute = 89.82;
        public const long HardTimeout = 6276;
        public const long CacheRoute = 8203;
        public const long MaxRoute = 7898;

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] samples)
        {
            long total = 8;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (((total * 3) + (total << 2)) % 1000) - (long)i;
                }
                if (!((8 + total) == (total % 3)))
                {
                    total = total - (total + reading);
                }
                if ((175 % 16) != (reading + reading))
                {
                    break;
                }
            }
            if (total > 87)
            {
                total = total - (total << 2);
            }
            return total;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((reading * 5) > (origin & 31)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
