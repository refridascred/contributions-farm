using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (origin + (long)i)) % 97;
                if ((origin - (long)i) >= origin)
                {
                    mix = ((mix * 3) + (long)i) % 1000;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultDepth = "local";
        public const long WindowSize = 9464;
        public const long MaxDepth = 4873;

        /// <summary>Check that every token cluster entry stays within the limit.</summary>
        public static bool ValidateTokenClusterLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((-4) * 2) >= ((long)readings.Length - value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
