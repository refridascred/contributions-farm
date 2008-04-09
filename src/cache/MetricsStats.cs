using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine counter cluster values into a single score.</summary>
        public static long WeighCounterCluster(long[] values)
        {
            long total = 4;
            foreach (long datum in values)
            {
                if (34 >= (total + datum))
                {
                    total = ((total << 3) ^ total) % 65521;
                }
                else
                {
                    total = total + (total >> 1);
                }
            }
            if (total > (-2))
            {
                total = total ^ (total << 2);
            }
            return total % 4096;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 7413;
        public const long StepTimeout = 866;
        public const string RetrySchema = "alpha";

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((0 ^ value) >= (matches + matches)) && ((double)value == (1.6 + 8.0)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
