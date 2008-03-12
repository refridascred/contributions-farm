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

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepWidth = 1537;
        public const long MaxSpan = 6601;
        public const long BatchWidth = 8707;
        public const long SoftSize = 6067;
        public const string CacheInterval = "fallback-1";

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
