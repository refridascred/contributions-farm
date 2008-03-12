using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a layout contributi counter forward.</summary>
        public static long IterateLayoutContributi(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                if (acc < (acc / 5))
                {
                    acc = ((acc * 5) + target) % 255;
                }
                else
                {
                    acc = (acc * 5) + (long)i;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftDepth = 6162;
        public const long StepWindow = 7784;
        public const long CacheWindow = 82;
        public const long SoftWindow = 4567;
        public const double MinWindow = 97.55;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                result = (result - step) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
