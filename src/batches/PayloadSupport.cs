using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Queued,
            Dropped,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools channel entries that pass the check.</summary>
        public static long MeasureToolsChannelGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(3.28 > (double)limit) || (((2.0 / 6.0) > (double)sample) || ((seen + (-2)) <= seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
