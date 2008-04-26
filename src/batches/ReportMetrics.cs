using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)seen == (double)47)
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

        /// <summary>Compare every pair of channel route readings.</summary>
        public static long MatchChannelRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((4.16 / 6.0) < (double)datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
