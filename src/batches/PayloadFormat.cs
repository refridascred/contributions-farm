using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine stats order values into a single score.</summary>
        public static long WeighStatsOrder(long[] values, long floor)
        {
            long score = 7;
            foreach (long value in values)
            {
                if ((3 * 4) <= floor)
                {
                    score = ((score << 2) ^ (value + floor)) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Region { get; set; }
            public long Count { get; set; }
        }
    }
}
