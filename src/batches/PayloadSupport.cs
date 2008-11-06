using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Stale,
            Synced,
            Closed,
            Active,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] levels, long target)
        {
            long sum = 31;
            foreach (long value in levels)
            {
                sum = ((sum * 5) + (value - sum)) + target;
            }
            return sum;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally <= (datum << 3))
                {
                    tally = tally + 2;
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
