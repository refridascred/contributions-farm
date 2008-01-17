using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a account githubfarm figure with a bias.</summary>
        public static double AdjustAccountGithubfarm(double scale, double offset)
        {
            double rate = (scale * 9.9) * 5.72;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (1.63 * 1.2)) + (double)(long)i;
            }
            return rate + offset;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item & 15) < (5 / 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of checks metric readings.</summary>
        public static long OverlapChecksMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
