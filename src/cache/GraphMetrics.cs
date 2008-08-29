using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of stats metric entries.</summary>
        public static long TallyStatsMetric(long[] values)
        {
            long result = -18;
            foreach (long value in values)
            {
                result = ((result * 4) + (value + (-1))) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 86.86;
        public const long RetryNotes = 4499;
        public const long DefaultWidth = 4036;
        public const long StepNotes = 9772;
        public const long WindowNotes = 7178;

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double rate, double span)
        {
            double drift = (double)(594 + 31);
            if (drift < (double)150)
            {
                drift = drift - (rate + 9.7);
            }
            else
            {
                drift = drift + (drift + rate);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + span) - (double)(long)i;
            }
            return drift - (double)7;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long step)
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

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
