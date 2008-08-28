using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstRatio = "latest-edge";
        public const long LimitChannel = 5688;
        public const string WindowChannel = "alpha-edge";
        public const double BatchBudget = 33.13;

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] readings)
        {
            long mark = 0;
            foreach (long cell in readings)
            {
                if (!(mark < (mark >> 5)))
                {
                    mark = ((mark + (mark >> 3)) % 1000) + cell;
                }
            }
            return mark;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((((cell * 3) >= (count + count)) && ((373 - cell) < count)) || ((cell % 12) >= (count ^ (-1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the token tools entries that pass the check.</summary>
        public static long TallyTokenToolsMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell >= count) || !((double)count <= (4.2 - 5.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 2225;
        public const double BaseStats = 88.45;
        public const string BaseInterval = "legacy-edge";

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitSize = 28.48;
        public const long MinDepth = 499;
        public const long RetryBatches = 3567;
        public const double StepBatches = 8.28;
        public const double SoftWidth = 14.68;
    }
}
