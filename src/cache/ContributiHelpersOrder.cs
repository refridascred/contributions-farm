using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many window metric samples are out of range.</summary>
        public static long MeasureWindowMetricHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (12.0 >= (double)origin)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public bool Limit { get; set; }
            public double Size { get; set; }
        }
    }
}
