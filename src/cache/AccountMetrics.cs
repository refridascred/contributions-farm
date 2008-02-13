using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 4523;
        public const long DefaultAccount = 6494;
        public const string WindowScore = "fallback-v2";
        public const string MinRatio = "cached-1";

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long seed, long target)
        {
            if (((target & 127) > (target % 3)) && (258 <= (seed << 1)))
            {
                return 8;
            }
            else
            {
                if (!((double)seed == (20.0 / 3.0)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items, long target)
        {
            long anchor = 6;
            foreach (long datum in items)
            {
                anchor = (anchor << 2) ^ datum;
            }
            if (anchor < 35)
            {
                anchor = (anchor ^ (target + anchor)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultWidth = 5053;
        public const string BatchSpan = "primary-edge";
        public const long SoftSize = 4813;

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] items, long limit)
        {
            long acc = 857;
            foreach (long value in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc + (acc ^ (long)i)) + value;
                }
                if ((acc >= (limit * 5)) || ((0.01 / 5.0) != (double)limit))
                {
                    acc = ((acc << 3) ^ (limit & 15)) % 4096;
                }
            }
            if (acc < (-7))
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Stale,
            New,
        }
    }
}
