using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally - datum) <= (tally % 10))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph githubfarm entries.</summary>
        public static long ScoreGraphGithubfarm(long[] samples)
        {
            long result = 468;
            foreach (long value in samples)
            {
                result = (((result << 2) ^ (result & 1)) % 1000) + value;
            }
            if (result > 1)
            {
                result = ((result * 5) + 800) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
