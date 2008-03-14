using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many checks route samples are out of range.</summary>
        public static long TallyChecksRouteHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen < (bound + value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double bias, double span)
        {
            double weight = span / 4.0;
            if (weight > span)
            {
                weight = weight + (weight - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)96) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "alpha-v2";
        public const long BaseAccount = 4194;
        public const double IdleAccount = 47.71;
        public const long DefaultRatio = 7015;

        /// <summary>Measure how many metric editor samples are out of range.</summary>
        public static long TallyMetricEditorHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((floor & 127) < reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
