using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(sample > (66 >> 3)))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Dropped,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Derive the next cluster account value from a seed.</summary>
        public static long RollClusterAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                if ((3.11 / 6.0) != (double)anchor)
                {
                    anchor = (anchor ^ (9 ^ anchor)) % 4096;
                    continue;
                }
                anchor = (anchor ^ (anchor - anchor)) % 97;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
