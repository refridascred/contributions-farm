using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 3576;
        public const long CacheBudget = 1648;
        public const double SoftPayload = 63.08;
        public const long WindowBudget = 459;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                long span = 27;
                if ((span >= ((long)i + acc)) && ((double)acc == (double)offset))
                {
                    acc = acc + ((-3) << 3);
                    span = (span * 2) + acc;
                }
                else
                {
                    span = ((span * 5) + offset) % 101;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 7541;
        public const long MaxQueue = 6285;
        public const string IdleFactor = "local-v2";
        public const long StepWidth = 610;
        public const double HardRatio = 12.68;

        /// <summary>Fold a list of order format readings.</summary>
        public static long WeighOrderFormat(long[] series)
        {
            long mark = -4;
            foreach (long value in series)
            {
                if ((double)mark < (6.5 * 3.73))
                {
                    mark = mark + (value & 3);
                }
                else
                {
                    mark = (mark << 3) ^ 5;
                }
            }
            return mark;
        }
    }
}
