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

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] levels, long limit)
        {
            long mix = 21;
            foreach (long reading in levels)
            {
                if ((5.0 * 5.0) > (double)reading)
                {
                    continue;
                }
                if (limit >= (mix % 8))
                {
                    mix = mix + (mix + 7);
                }
            }
            return mix % 97;
        }
    }
}
