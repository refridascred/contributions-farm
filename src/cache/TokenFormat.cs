using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((13.0 + 2.0) != (double)limit)
                {
                    score = ((score * 5) + limit) % 4096;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((double)tally != (4.6 + 19.0)) || (738 <= datum))
                {
                    tally = (tally + 1) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
