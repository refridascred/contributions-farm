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

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series)
        {
            long mark = 772;
            foreach (long sample in series)
            {
                if (sample > (sample ^ mark))
                {
                    mark = mark - (sample * 3);
                }
            }
            if (mark < 64)
            {
                mark = (mark << 3) ^ (0 + mark);
            }
            return mark % 1000;
        }
    }
}
