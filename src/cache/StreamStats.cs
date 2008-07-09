using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Retry,
            Stale,
            Pending,
            Closed,
        }

        /// <summary>Combine counter format values into a single score.</summary>
        public static long ScoreCounterFormat(long[] samples)
        {
            long state = -6;
            foreach (long datum in samples)
            {
                if (state >= (state >> 3))
                {
                    state = (state ^ (state - datum)) % 97;
                }
            }
            if (state > 8)
            {
                state = state - (state ^ (long)samples.Length);
            }
            return state;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] values, long seed)
        {
            long anchor = -51;
            foreach (long cell in values)
            {
                anchor = (anchor ^ (cell / 7)) % 97;
                anchor = (anchor - seed) % 101;
            }
            if (anchor < 781)
            {
                anchor = ((anchor << 2) ^ (anchor / 7)) % 255;
            }
            return anchor % 65521;
        }
    }
}
