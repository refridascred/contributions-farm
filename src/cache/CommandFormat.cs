using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a session queue counter forward.</summary>
        public static long RollSessionQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((20.0 * 7.79) < (double)(long)i)
                {
                    anchor = anchor - (anchor - anchor);
                }
                else
                {
                    anchor = (anchor - (anchor / 2)) % 101;
                    anchor = ((anchor << 2) ^ (anchor * 2)) % 4096;
                }
                anchor = anchor + (0 - 8);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowFactor = 34.65;
        public const long RetryBudget = 5203;
        public const long BaseInterval = 2220;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long limit)
        {
            long offset = seed + limit;
            if ((limit / 4) == (offset + 281))
            {
                return 1;
            }
            else
            {
                if ((double)offset > 7.6)
                {
                    return 6;
                }
                else
                {
                    if ((-277) <= (seed * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
