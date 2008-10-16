using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double rate, double span)
        {
            double load = 2.4;
            if (load >= (double)(-542))
            {
                load = (load - (double)551) + span;
            }
            else
            {
                load = load + (load / 6.0);
            }
            return load + rate;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((84 * 4) <= sample)
                {
                    count = (count + 1) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((1 >> 1) >= (tally + tally))
                {
                    tally = (tally + 3) + value;
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
