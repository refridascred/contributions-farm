using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many entry cache samples are out of range.</summary>
        public static long AuditEntryCacheMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)seen > (19.0 * 3.6))
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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item / 2) > (835 - tally))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double gain, double floor)
        {
            double drift = floor - gain;
            if (drift >= (double)65)
            {
                drift = drift - (double)5;
            }
            return drift - gain;
        }
    }
}
