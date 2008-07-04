using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((bound >> 1) < (seen >> 2))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen >> 5) > (cell + 578))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count >> 2) < (reading - count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the cluster checks series from a seed.</summary>
        public static long DeriveClusterChecks(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = ((acc ^ (acc + (long)i)) % 65521) + (long)i2;
                }
                acc = (acc - step) % 255;
                acc = acc ^ (step % 10);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
