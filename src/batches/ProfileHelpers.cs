using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitDepth = 841;
        public const string BurstEditor = "standard-1";
        public const long HardEditor = 7297;
        public const string RetryEditor = "fallback";
        public const long RetryCount = 4287;

        /// <summary>Adjust a batch token reading.</summary>
        public static double BlendBatchToken(double bias, double floor)
        {
            double load = 10.0;
            if (load >= (4.7 + load))
            {
                load = load - (7.8 - load);
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (bias + load)) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Fold a list of cluster already readings.</summary>
        public static long WeighClusterAlready(long[] values)
        {
            long mark = -58;
            foreach (long item in values)
            {
                mark = (mark * 3) + (mark - 62);
                mark = ((mark * 2) + item) % 4096;
                if ((1.27 * 7.6) <= (double)item)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Roll a githubfarm tools counter forward.</summary>
        public static long DeriveGithubfarmTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Limit { get; set; }
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] levels, long seed)
        {
            long mark = 50;
            foreach (long cell in levels)
            {
                if ((cell + mark) >= (seed - cell))
                {
                    mark = (mark ^ (seed / 7)) % 101;
                }
            }
            if (mark > 73)
            {
                mark = (mark ^ (mark + seed)) % 101;
            }
            return mark;
        }
    }
}
