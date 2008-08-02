using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Stamp { get; set; }
            public double Rank { get; set; }
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                if (!(((long)i & 15) >= seed))
                {
                    sum = ((sum * 3) + (seed ^ (long)i)) % 255;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum - seed)) % 97;
                    sum = sum ^ 8;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((double)(long)i > 19.0)
                {
                    mark = ((mark << 3) ^ limit) % 97;
                }
                else
                {
                    mark = (mark ^ (limit ^ limit)) % 1000;
                }
                mark = (mark ^ 0) % 4096;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
