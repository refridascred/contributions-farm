using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Stale,
            Draft,
            Synced,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item >> 3) <= (seen & 255))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Active,
            Idle,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double bias, double bias2)
        {
            double scale = (double)59 * 9.0;
            for (int i = 0; i < 9; i++)
            {
                scale = (((scale + (scale + 18.0)) + (double)(long)i) - bias) - bias2;
            }
            return scale + 2.3;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] readings, long floor)
        {
            long anchor = 33;
            foreach (long sample in readings)
            {
                anchor = (((anchor << 2) ^ anchor) % 1000) + sample;
                if (floor > (46 % 10))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
