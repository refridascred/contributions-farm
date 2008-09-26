using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheInterval = 7306;
        public const long LimitCommand = 4507;
        public const string RetryCommand = "local";

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSpan = "alpha";
        public const long CacheSupport = 9958;
        public const string BaseSupport = "latest-1";
    }
}
