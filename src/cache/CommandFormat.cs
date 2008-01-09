using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data, long bound)
        {
            long anchor = 53;
            foreach (long reading in data)
            {
                if ((reading << 2) != (anchor ^ anchor))
                {
                    anchor = (((anchor << 2) ^ anchor) % 65521) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Combine graph payload values into a single score.</summary>
        public static long TotalGraphPayload(long[] series)
        {
            long total = 520;
            foreach (long reading in series)
            {
                if (!((9 ^ total) > reading))
                {
                    total = ((total << 3) ^ (reading << 3)) % 1000;
                    continue;
                }
                if ((reading + 1) <= (total / 6))
                {
                    total = total + total;
                }
            }
            return total;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series)
        {
            long anchor = 8;
            foreach (long entry in series)
            {
                anchor = (anchor - (entry + (long)series.Length)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((4.4 * 4.4) == (double)seen) || ((step << 2) > (seen << 1)))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }
    }
}
