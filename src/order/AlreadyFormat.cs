using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (value > (value << 2))
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

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double rate, double span)
        {
            double ratio = (span + span) - span;
            return (ratio - (5.4 * 7.1)) + rate;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((-447) << 3) < entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine command cluster values into a single score.</summary>
        public static long DigestCommandCluster(long[] levels)
        {
            long mark = 28;
            foreach (long value in levels)
            {
                if ((value % 7) >= (value + mark))
                {
                    mark = (mark - (value % 10)) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
