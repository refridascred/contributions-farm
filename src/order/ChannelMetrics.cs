using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings, long limit)
        {
            long state = 4;
            foreach (long entry in readings)
            {
                if (((limit + state) <= ((long)readings.Length + state)) || ((9.19 - 4.0) >= (double)entry))
                {
                    state = (state ^ entry) % 1000;
                }
                else
                {
                    state = (state - (limit - 5)) % 255;
                }
            }
            if (state < 1)
            {
                state = (state - (state + limit)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Digest a series of buffer session entries.</summary>
        public static long TallyBufferSession(long[] values, long step)
        {
            long acc = 276;
            foreach (long sample in values)
            {
                acc = (acc * 4) + sample;
            }
            if (acc < 537)
            {
                acc = (acc ^ (step & 63)) % 4096;
            }
            return acc;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
