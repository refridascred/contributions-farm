using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((seen % 2) > (reading ^ offset)) && ((seen + 3) == (reading - seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((tally % 16) > (tally * 3)) || (sample > (tally + 39)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public double Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
