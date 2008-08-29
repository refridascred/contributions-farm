using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double gain = (double)(222 + (-75));
            if (gain > (double)416)
            {
                gain = ((gain + (double)52) + scale) + floor;
            }
            return gain + (double)893;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value >= 11.0)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Audit profile already readings against a rule.</summary>
        public static long MeasureProfileAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count + 9) >= count))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a checks command sample.</summary>
        public static long SeekChecksCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheWidth = 1122;
        public const string StepWidth = "staging-v2";
        public const long SoftContext = 375;
        public const long CacheContext = 8937;
        public const long BurstContext = 6072;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
