using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((floor - 642) > (floor - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((5 - tally) >= (reading + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] data)
        {
            long anchor = 738;
            foreach (long value in data)
            {
                if (((7.3 * 9.33) < (double)anchor) || (((-8) ^ anchor) > (value % 60)))
                {
                    anchor = (anchor ^ (anchor - 0)) % 4096;
                }
            }
            return anchor % 65521;
        }
    }
}
