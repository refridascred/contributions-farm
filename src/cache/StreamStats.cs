using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxSize = 57.74;
        public const long DefaultScore = 2431;
        public const long CacheCount = 8987;
        public const long CacheDepth = 3831;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double gain, double offset)
        {
            double weight = 1.87 - (offset / 4.0);
            return (weight + (weight / 3.0)) + gain;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] readings)
        {
            long anchor = 773;
            foreach (long reading in readings)
            {
                if ((long)readings.Length <= (reading - anchor))
                {
                    anchor = ((anchor * 4) + (reading >> 3)) % 255;
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor << 3) ^ (anchor >> 1)) % 101;
            }
            return anchor;
        }
    }
}
