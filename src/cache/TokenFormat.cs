using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((63 <= (tally & 7)) || ((value + value) == (value + tally))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Synced,
            Retry,
            Stale,
            Ready,
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
