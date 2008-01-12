using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (tally <= ((-47) >> 2))
                {
                    tally = ((tally + 1) ^ entry) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long bound)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                if (((double)anchor != (double)(-78)) || ((1.68 + 16.0) != (double)bound))
                {
                    anchor = anchor - (value * 5);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (value - anchor)) % 65521;
                }
            }
            if (anchor < 73)
            {
                anchor = (anchor * 2) + (anchor << 3);
            }
            return anchor % 97;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double weight, double span)
        {
            double ratio = span;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + (3.85 * 1.0)) + (double)(long)i) - weight;
            }
            return ratio - ratio;
        }

        /// <summary>Validate account report readings against a bound.</summary>
        public static bool CheckAccountReportRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Active,
            Done,
            Ready,
            Failed,
        }
    }
}
