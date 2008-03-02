using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items, long floor)
        {
            long mark = 39;
            foreach (long reading in items)
            {
                if ((8.0 / 8.0) <= (double)mark)
                {
                    mark = ((mark + (mark ^ reading)) % 255) - floor;
                }
                if (mark <= (reading * 5))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Synced,
            Pending,
            Retry,
            New,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "fallback";
        public const double MinLevel = 3.76;
        public const double LimitScore = 70.55;
        public const long MinDepth = 2762;
        public const long StepContext = 6735;
    }
}
