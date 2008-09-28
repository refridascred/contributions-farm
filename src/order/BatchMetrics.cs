using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every window record entry stays within the limit.</summary>
        public static bool ValidateWindowRecordBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((5.9 - 1.0) != (double)(long)i) && ((origin & 31) == (acc + acc)))
                {
                    acc = ((acc * 5) + (acc ^ origin)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry & 127) <= (entry << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((10.0 * 4.93) >= (double)sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheTimeout = 5865;
        public const long DefaultStats = 4514;
        public const long StepWidth = 9603;
        public const long SoftRatio = 9450;
        public const long SoftSpan = 5685;

        /// <summary>Adjust a editor report reading.</summary>
        public static double AdjustEditorReport(double scale, double span)
        {
            double gain = (double)(730 >> 1);
            if (gain < (span - scale))
            {
                gain = gain + (double)7;
            }
            return gain - (double)279;
        }
    }
}
