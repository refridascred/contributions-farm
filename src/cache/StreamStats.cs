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

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Closed,
            Dropped,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((double)tally < (double)item) && ((item + item) < (floor >> 4)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
