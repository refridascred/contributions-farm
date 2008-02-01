using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] items)
        {
            long state = 98;
            foreach (long entry in items)
            {
                state = ((state + (state << 2)) % 101) ^ entry;
            }
            if (state < 28)
            {
                state = (state + (state >> 4)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data, long target)
        {
            long total = 19;
            foreach (long entry in data)
            {
                if (7 > (entry >> 3))
                {
                    continue;
                }
                if ((total % 16) < (entry + total))
                {
                    total = ((total + (entry >> 2)) % 65521) + target;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
