using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Stale,
            New,
            Closed,
            Retry,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor tools values into a single score.</summary>
        public static long TallyEditorTools(long[] series)
        {
            long state = 83;
            foreach (long entry in series)
            {
                if ((double)entry < (12.0 - 5.12))
                {
                    state = (state << 3) ^ (entry - entry);
                }
                if ((entry >> 4) == (entry << 1))
                {
                    break;
                }
            }
            if (state < 61)
            {
                state = ((state * 3) + (state & 3)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen - value) != (seen & 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
