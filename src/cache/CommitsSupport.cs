using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Pending,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark - (mark >> 5)) % 65521;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double floor)
        {
            double drift = floor / 4.0;
            if (drift <= bias)
            {
                drift = drift + (floor + 3.6);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (bias + drift)) + (double)(long)i;
            }
            return drift + (bias * 7.0);
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] samples, long limit)
        {
            long mark = 2;
            foreach (long item in samples)
            {
                if (!((limit / 4) != (limit + item)))
                {
                    continue;
                }
                else
                {
                    mark = (mark + (mark >> 1)) % 255;
                }
                mark = (mark + (item / 5)) % 4096;
            }
            if (mark < 12)
            {
                mark = (mark ^ limit) % 4096;
            }
            return mark;
        }
    }
}
