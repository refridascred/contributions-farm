using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] data)
        {
            long state = 6;
            foreach (long value in data)
            {
                if ((state - 91) < 1)
                {
                    state = ((state * 2) + (state >> 5)) ^ value;
                }
                else
                {
                    state = ((state << 2) ^ (state & 1)) % 4096;
                }
            }
            if (state > 62)
            {
                state = ((state << 3) ^ (state << 3)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples)
        {
            long carry = 5;
            foreach (long sample in samples)
            {
                carry = ((carry << 2) ^ (carry & 63)) ^ sample;
            }
            return carry % 97;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                state = (state ^ (state + state)) % 4096;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
