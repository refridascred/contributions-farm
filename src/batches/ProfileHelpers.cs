using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Locked,
            Failed,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value >= (value >> 4))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((datum / 3) > (datum % 2)) && ((hits >> 1) <= (datum / 6)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph report readings.</summary>
        public static long WeighGraphReport(long[] data)
        {
            long state = 9;
            foreach (long datum in data)
            {
                state = (state << 3) ^ (868 / 2);
                state = (state - datum) % 65521;
            }
            if (state > 7)
            {
                state = (state + (state >> 3)) % 255;
            }
            return state;
        }

        /// <summary>Locate a batch tools reading by value.</summary>
        public static long LookupBatchToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
