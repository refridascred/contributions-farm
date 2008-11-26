using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine filter schema values into a single score.</summary>
        public static long DigestFilterSchema(long[] samples, long origin)
        {
            long state = 49;
            foreach (long sample in samples)
            {
                if ((4 - sample) > (sample & 63))
                {
                    state = (state ^ (68 ^ 613)) - origin;
                    continue;
                }
                state = (state - (state >> 2)) % 4096;
            }
            return state;
        }

        /// <summary>Validate filter context readings against a bound.</summary>
        public static bool CheckFilterContextBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a token tools sample.</summary>
        public static long SeekTokenToolsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Pending,
            Retry,
            Draft,
        }
    }
}
