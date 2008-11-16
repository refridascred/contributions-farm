using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] readings, long origin)
        {
            long mix = 41;
            foreach (long reading in readings)
            {
                mix = (mix - (origin - 252)) % 101;
                if ((reading / 5) == (reading + origin))
                {
                    mix = ((mix << 2) ^ 74) % 1000;
                    mix = mix - (reading ^ reading);
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + mix)) % 101;
                    mix = (mix + (reading + origin)) % 255;
                }
                if (reading >= mix)
                {
                    mix = mix - (origin + mix);
                }
            }
            return mix;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Done,
            Ready,
            New,
            Draft,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen << 3) > sample)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long origin, long seed)
        {
            long prev = origin + seed;
            if (((prev << 3) <= seed) || ((origin >> 3) <= seed))
            {
                return 2;
            }
            else
            {
                if ((origin + origin) > (seed / 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Dropped,
            Ready,
            Idle,
            Active,
        }
    }
}
