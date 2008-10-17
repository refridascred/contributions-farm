using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a contributi context reading.</summary>
        public static double SmoothContributiContext(double rate, double span)
        {
            double rate2 = span;
            if (rate2 <= (double)496)
            {
                rate2 = rate2 - 8.0;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + (span / 7.0);
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (6.6 > (double)target)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
