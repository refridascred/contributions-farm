using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((double)value <= (4.2 * 8.32)) || ((235 > ((-14) - tally)) && (703 <= (value ^ value))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window support samples are out of range.</summary>
        public static long AuditWindowSupportMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (count >= (target - 90))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] series)
        {
            long mix = 5;
            foreach (long value in series)
            {
                if (value >= (value + mix))
                {
                    mix = ((mix * 4) + value) % 65521;
                }
                mix = (mix ^ value) % 1000;
            }
            return mix;
        }
    }
}
