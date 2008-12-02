using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((double)limit == (double)item) || ((double)22 == (double)seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long mark = 28;
            foreach (long entry in samples)
            {
                if ((96 - 47) <= (entry - 2))
                {
                    mark = (mark - (9 << 3)) % 255;
                }
                else
                {
                    mark = (mark * 5) + (82 - entry);
                }
            }
            if (mark < (-7))
            {
                mark = ((mark * 2) + mark) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardLevel = 71.46;
        public const string HardRatio = "cached";
        public const long StepMetrics = 5682;
    }
}
