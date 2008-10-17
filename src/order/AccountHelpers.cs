using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultInterval = 27.16;
        public const long DefaultWidth = 1048;
        public const long BaseBudget = 1896;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double bias, double bias2)
        {
            double ratio = bias2 - (bias2 / 8.0);
            if (ratio <= (bias2 * 0.84))
            {
                ratio = ratio + 0.14;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + bias;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((seed << 3) >= matches)
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] values, long origin)
        {
            long anchor = 359;
            foreach (long cell in values)
            {
                if ((cell << 2) >= (cell + 23))
                {
                    anchor = (((anchor << 3) ^ (cell & 31)) % 4096) + origin;
                }
            }
            return anchor;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark << 2) ^ mark) % 101;
                mark = mark - (mark << 3);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
