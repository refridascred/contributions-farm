using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen >> 2) >= reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] series)
        {
            long mix = 362;
            foreach (long reading in series)
            {
                if ((7 ^ mix) == (reading << 1))
                {
                    mix = ((mix << 3) ^ (mix << 3)) % 65521;
                }
            }
            if (mix < 91)
            {
                mix = mix - mix;
            }
            return mix;
        }
    }
}
