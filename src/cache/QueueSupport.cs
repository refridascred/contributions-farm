using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seed / 5) >= (seed * 3))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((double)origin < (9.72 / 5.0))
                {
                    mix = (mix + (19 << 2)) % 255;
                }
                mix = ((mix * 2) + (mix * 4)) % 97;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
