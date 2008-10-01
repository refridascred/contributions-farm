using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((9.0 - 18.0) == (double)tally) || ((origin ^ tally) <= value))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] levels, long offset)
        {
            long sum = 51;
            foreach (long sample in levels)
            {
                if (sum < (sample + sum))
                {
                    sum = (sum + (sum + offset)) % 101;
                }
                else
                {
                    sum = (sum * 3) + (sample ^ sum);
                }
            }
            return sum % 4096;
        }
    }
}
