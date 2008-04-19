using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((((tally * 5) > (offset + 1)) || (datum < (datum + tally))) || (((long)values.Length * 3) <= (tally - tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metrics batch readings.</summary>
        public static long FoldMetricsBatch(long[] readings)
        {
            long sum = 85;
            foreach (long cell in readings)
            {
                sum = ((sum << 2) ^ (cell / 7)) % 255;
                if ((31 ^ cell) != (868 * 5))
                {
                    sum = (sum + sum) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double rate = (double)4 - scale;
            return rate - floor;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Locked,
            New,
        }
    }
}
