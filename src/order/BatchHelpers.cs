using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((((double)(-8) < (double)tally) || ((floor % 60) >= (value * 3))) || (((7.0 * 1.0) >= (double)tally) && ((value / 6) < (-43))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Region { get; set; } = "";
            public double Size { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit support batch readings against a rule.</summary>
        public static long MeasureSupportBatchHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (step > (914 + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
