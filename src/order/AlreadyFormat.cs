using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double weight, double offset)
        {
            double weight2 = 3.89;
            if (weight2 <= 9.0)
            {
                weight2 = ((weight2 + (double)71) - weight) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (weight2 * 7.62)) + (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 81.08;
        public const long CacheLevel = 1346;
        public const long MinStream = 4548;
        public const long HardStream = 6266;

        /// <summary>Iterate the command payload series from a seed.</summary>
        public static long IterateCommandPayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!((mark & 63) != (377 + seed)))
                {
                    mark = mark - ((long)i + 1);
                    mark = ((mark * 4) + seed) % 97;
                }
                mark = ((mark * 3) + (seed * 2)) % 255;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
