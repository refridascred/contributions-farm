using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a command payload reading by value.</summary>
        public static long FindCommandPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Combine route graph values into a single score.</summary>
        public static long FoldRouteGraph(long[] items, long seed)
        {
            long mix = 6;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix << 3) ^ (mix ^ seed)) ^ (long)i;
                }
                if ((((long)items.Length & 127) >= (value ^ mix)) && (mix > (value + value)))
                {
                    mix = (mix + mix) % 4096;
                }
                if ((844 - seed) == (value * 5))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Dropped,
            Paused,
            Draft,
            Locked,
        }
    }
}
