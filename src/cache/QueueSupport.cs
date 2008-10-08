using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((sample & 15) < (921 << 3)) && ((sample << 1) >= ((long)items.Length + origin)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (floor > (seen + (long)series.Length))
                {
                    seen = (seen + 3) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Active,
            Retry,
            New,
            Ready,
        }
    }
}
