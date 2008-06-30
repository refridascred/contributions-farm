using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine record stats values into a single score.</summary>
        public static long TallyRecordStats(long[] readings, long step)
        {
            long result = -48;
            foreach (long datum in readings)
            {
                result = (result - (step & 255)) + datum;
            }
            if (result > 8)
            {
                result = (result << 2) ^ (step + result);
            }
            return result;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((tally % 8) < limit) && (((double)limit > 18.0) && ((81 << 1) > (sample & 1))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next support graph value from a seed.</summary>
        public static long StepSupportGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
