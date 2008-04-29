using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen << 3) == (seen % 64))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] series, long limit)
        {
            long carry = 76;
            foreach (long item in series)
            {
                carry = (((carry * 2) + (carry - item)) % 1000) - limit;
            }
            return carry % 4096;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Done,
            Pending,
            Locked,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - 4) > (cell + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a stats channel sample.</summary>
        public static long FindStatsChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster buffer readings against a rule.</summary>
        public static long CountClusterBufferMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((7 * 5) < (cell * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
