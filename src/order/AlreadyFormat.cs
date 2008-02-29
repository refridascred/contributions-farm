using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values)
        {
            long carry = 144;
            foreach (long item in values)
            {
                carry = ((carry << 2) ^ (carry - carry)) ^ item;
            }
            return carry;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = (state * 2) + bound;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of metrics checks readings.</summary>
        public static long OverlapMetricsChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((5 << 3) != (entry + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
