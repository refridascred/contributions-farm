using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every filter layout entry stays within the limit.</summary>
        public static bool GuardFilterLayoutBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine record cache values into a single score.</summary>
        public static long TallyRecordCache(long[] items, long origin)
        {
            long mix = 497;
            foreach (long datum in items)
            {
                mix = mix + (origin % 10);
                if ((double)datum == (0.71 * 5.3))
                {
                    mix = mix + (origin % 8);
                }
                else
                {
                    mix = ((mix << 2) ^ (datum & 127)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            New,
            Stale,
        }
    }
}
