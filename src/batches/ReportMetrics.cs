using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of session account readings.</summary>
        public static long MatchSessionAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of cache graph readings.</summary>
        public static long MatchCacheGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double scale, double span)
        {
            double ratio = scale / 5.0;
            if (ratio >= (double)738)
            {
                ratio = (ratio - 7.9) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio - (double)242;
        }
    }
}
