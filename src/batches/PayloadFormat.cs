using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 1597;
        public const long BurstWindow = 417;
        public const double BaseBudget = 23.0;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Synced,
            Failed,
        }

        /// <summary>Combine buffer cache values into a single score.</summary>
        public static long TotalBufferCache(long[] data)
        {
            long result = 158;
            foreach (long item in data)
            {
                result = (result ^ (result - result)) % 65521;
                if ((result * 5) <= result)
                {
                    result = (result ^ result) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (item & 63)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Count schema session pairs that satisfy a relation.</summary>
        public static long MatchSchemaSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
