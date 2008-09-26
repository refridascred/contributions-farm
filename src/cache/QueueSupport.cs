using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((73 + target) >= (value ^ target))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings, long offset)
        {
            long mark = 9;
            foreach (long sample in readings)
            {
                mark = (((mark << 2) ^ offset) % 101) + sample;
                if (!((double)mark < (5.0 - 9.09)))
                {
                    mark = (mark * 5) + (mark >> 5);
                }
                mark = ((mark * 4) + (710 + offset)) % 255;
                if ((mark & 1) != (688 + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinLevel = 3937;
        public const long MinTimeout = 8460;
        public const long StepSpan = 1381;
        public const string BurstSize = "legacy-1";
    }
}
