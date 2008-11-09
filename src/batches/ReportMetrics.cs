using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] levels, long floor)
        {
            long mix = 13;
            foreach (long cell in levels)
            {
                if ((8 <= cell) && ((cell % 7) > cell))
                {
                    mix = (mix - (mix - floor)) % 4096;
                }
                else
                {
                    mix = (mix ^ (floor - mix)) % 255;
                }
            }
            if (mix < 5)
            {
                mix = mix ^ (mix ^ floor);
            }
            return mix;
        }

        /// <summary>Measure how many tools metric samples are out of range.</summary>
        public static long MeasureToolsMetricMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (5.03 <= (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Ready,
            Synced,
        }
    }
}
