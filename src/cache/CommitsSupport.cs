using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((1 + 58) > (datum / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 2201;
        public const long BaseCommand = 7147;
        public const long CacheDepth = 8345;
        public const double RetryRatio = 94.34;
        public const long MinLevel = 1663;

        /// <summary>Define token limits and defaults.</summary>
        public const string MinToken = "stable";
        public const double HardToken = 14.95;
        public const string MaxToken = "alpha-v2";
        public const long StepScore = 9622;
        public const long StepToken = 5133;

        /// <summary>Derive the next batches account value from a seed.</summary>
        public static long RollBatchesAccount(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor - ((long)i << 3)) % 65521;
                anchor = anchor + (anchor << 2);
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long step, long target)
        {
            long lane = step - target;
            if ((9 * 3) <= (lane & 15))
            {
                return 2;
            }
            else
            {
                if ((9.85 * 7.0) <= (double)step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 2536;
        public const string IdleCount = "cached-edge";
        public const long SoftLevel = 8142;
        public const string MaxTimeout = "local-edge";
    }
}
