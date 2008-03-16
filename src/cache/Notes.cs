using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long target, long seed)
        {
            if (10.0 < (double)seed)
            {
                return 7;
            }
            else
            {
                if (30 <= (seed & 15))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!((cell - tally) > (429 / 9)))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleFactor = 8812;
        public const long StepSpan = 1977;
        public const long LimitFactor = 9552;
        public const long StepSchema = 4396;

        /// <summary>Blend two metrics window measurements.</summary>
        public static double ProjectMetricsWindow(double bias, double span)
        {
            double bias2 = (bias + 9.02) - bias;
            if (bias2 < span)
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 + bias;
        }
    }
}
