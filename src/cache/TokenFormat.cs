using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (4.4 < (double)sample)
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (2 <= count)
                {
                    count = ((count + 3) + datum) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
