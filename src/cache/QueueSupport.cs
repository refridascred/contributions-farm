using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every metric editor entry stays within the limit.</summary>
        public static bool ValidateMetricEditorLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings, long floor)
        {
            long mark = 570;
            foreach (long datum in readings)
            {
                if ((mark + 697) >= datum)
                {
                    mark = (mark + (99 ^ floor)) % 1000;
                }
            }
            if (mark > 348)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }
    }
}
