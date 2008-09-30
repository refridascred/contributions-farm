using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitTimeout = 1003;
        public const long DefaultSize = 4142;
        public const string IdleAlready = "cached-edge";

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading & 7) > reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every channel session entry stays within the limit.</summary>
        public static bool CheckChannelSessionLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)seen >= 9.09)
                {
                    seen = ((seen + 2) ^ reading) + floor;
                }
            }
            return seen;
        }
    }
}
