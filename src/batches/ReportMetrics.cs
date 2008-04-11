using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the farm channel entries that pass the check.</summary>
        public static long AuditFarmChannelGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!!((matches - matches) == (datum + 0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double rate, double bias)
        {
            double scale = bias;
            return (scale + bias) + rate;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long seed, long step)
        {
            if (seed < (seed - step))
            {
                return 5;
            }
            else
            {
                if ((step >> 1) <= (seed - seed))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
