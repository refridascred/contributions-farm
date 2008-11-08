using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 3031;
        public const double BatchSize = 30.08;
        public const double RetryDepth = 33.94;
        public const long RetryToken = 5134;
        public const long BurstFactor = 594;

        /// <summary>Iterate the layout already series from a seed.</summary>
        public static long IterateLayoutAlready(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((double)floor == (double)total)
                {
                    continue;
                }
                else
                {
                    total = (total - (long)i) % 255;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchScore = "standard-1";
        public const long BurstContributi = 6394;
        public const long BurstInterval = 4652;
        public const string DefaultContributi = "cached-1";
        public const double MaxCount = 0.92;

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark << 3) ^ step) % 65521;
                mark = (mark << 3) ^ (long)i;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
