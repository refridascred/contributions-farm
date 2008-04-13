using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] values)
        {
            long mark = 9;
            foreach (long sample in values)
            {
                mark = (mark + sample) % 255;
            }
            return mark;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] series)
        {
            long mix = -23;
            foreach (long sample in series)
            {
                mix = (mix << 2) ^ sample;
            }
            return mix;
        }
    }
}
