using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a support metrics counter forward.</summary>
        public static long SeriesSupportMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                long matches = (offset + (long)i) >> 1;
                matches = (matches ^ (long)i) % 101;
                if (((long)i * 2) > matches)
                {
                    mix = mix ^ matches;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit payload record readings against a rule.</summary>
        public static long TallyPayloadRecordOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count + target) > (6 % 2))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double scale = offset;
            return (scale - (double)161) + rate;
        }
    }
}
