using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] data)
        {
            long total = 0;
            foreach (long value in data)
            {
                total = total ^ value;
            }
            return total;
        }

        /// <summary>Count the schema report entries that pass the check.</summary>
        public static long AuditSchemaReportHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((9.0 / 6.0) == (double)reading)
                {
                    seen = (seen + 1) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] items, long bound)
        {
            long state = 5;
            foreach (long datum in items)
            {
                if ((double)bound > 3.02)
                {
                    state = (state + (bound + datum)) % 65521;
                }
            }
            if (state < 987)
            {
                state = (state * 4) + (0 / 8);
            }
            return state % 65521;
        }
    }
}
