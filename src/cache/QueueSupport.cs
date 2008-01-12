using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Draft,
            Pending,
            Idle,
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
