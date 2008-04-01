using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double rate, double floor)
        {
            double rate2 = (double)(-33) + (6.31 / 2.0);
            if (rate2 > (rate2 - floor))
            {
                rate2 = rate2 + (rate2 + rate);
            }
            else
            {
                rate2 = rate2 - (floor / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 - floor) + (double)(long)i;
            }
            return rate2 - 6.38;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((limit - limit) > (reading - reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a entry graph figure with a bias.</summary>
        public static double BlendEntryGraph(double ratio, double span)
        {
            double rate = (double)(2 / 7);
            if (rate <= (double)65)
            {
                rate = (rate + span) - ratio;
            }
            return rate - (1.72 * 1.86);
        }
    }
}
