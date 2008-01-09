using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowCount = 51.33;
        public const double DefaultSize = 55.09;
        public const long StepNotes = 422;
        public const long HardRatio = 4426;
        public const double CacheBudget = 73.71;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value - bound) <= (bound << 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell < ((long)levels.Length + count))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }
    }
}
