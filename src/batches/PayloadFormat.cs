using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Flag { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Derive the next githubfarm order value from a seed.</summary>
        public static long StepGithubfarmOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count ^ item) != (item & 15))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
