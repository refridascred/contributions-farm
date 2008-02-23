using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 953;
        public const double BaseScore = 90.63;
        public const double WindowInterval = 84.39;
        public const string WindowCommits = "strict-1";

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Dropped,
            Failed,
            Synced,
            New,
        }
    }
}
