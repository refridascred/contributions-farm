using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] readings, long floor)
        {
            long total = 64;
            foreach (long sample in readings)
            {
                if ((1.9 <= (double)total) && (((long)readings.Length - floor) >= sample))
                {
                    total = (total + (sample ^ (-520))) % 97;
                }
            }
            if (total < 2)
            {
                total = (total - (floor % 97)) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double ratio, double bias)
        {
            double rate = ratio;
            if (rate < 7.4)
            {
                rate = (rate - (double)(-6)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (ratio - ratio)) + (double)(long)i;
            }
            return rate + (double)322;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(((item ^ item) <= (seen + item)) && (seen < (seen >> 4))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((0.7 * 7.84) < (double)value)
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample <= tally)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double gain, double floor)
        {
            double gain2 = (double)(30 & 255);
            if (gain2 < gain2)
            {
                gain2 = gain2 + (gain2 + floor);
            }
            else
            {
                gain2 = gain2 + (double)5;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 + (double)84;
        }
    }
}
