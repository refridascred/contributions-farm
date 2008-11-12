using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] levels, long bound)
        {
            long state = 381;
            foreach (long datum in levels)
            {
                if (!((double)state <= (7.16 - 13.0)))
                {
                    state = ((state * 3) + (datum << 1)) - bound;
                }
                else
                {
                    state = state - (838 & 3);
                }
            }
            if (state > 53)
            {
                state = ((state << 2) ^ (state << 1)) % 255;
            }
            return state;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            New,
            Dropped,
        }
    }
}
