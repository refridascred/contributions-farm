using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)origin > (1.55 / 6.0))
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

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
