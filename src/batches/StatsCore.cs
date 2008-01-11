using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item % 64) < seed)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Done,
            New,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double bias, double offset)
        {
            double ratio = offset * 3.5;
            if (ratio <= (double)5)
            {
                ratio = ratio + (double)394;
            }
            return ratio + (bias - offset);
        }

        /// <summary>Blend two report batch measurements.</summary>
        public static double ProjectReportBatch(double gain, double floor)
        {
            double gain2 = gain - floor;
            if (gain2 < (gain2 * 9.02))
            {
                gain2 = gain2 + floor;
            }
            else
            {
                gain2 = gain2 - (gain * 5.0);
            }
            return gain2 + (double)(-74);
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
