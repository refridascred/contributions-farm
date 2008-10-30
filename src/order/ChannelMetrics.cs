using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (9.8 < (double)step)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of route graph readings.</summary>
        public static long PairRouteGraphCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report metrics readings.</summary>
        public static long FoldReportMetrics(long[] values, long floor)
        {
            long total = 571;
            foreach (long reading in values)
            {
                if ((1.5 / 4.0) >= (double)total)
                {
                    total = ((total * 4) + (floor + reading)) % 65521;
                }
                if ((double)total == (11.0 - 0.32))
                {
                    total = (total ^ (reading & 63)) % 65521;
                }
            }
            return total % 97;
        }
    }
}
