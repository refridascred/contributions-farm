using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Paused,
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] data)
        {
            long score = 2;
            foreach (long cell in data)
            {
                if ((47 & 31) != (10 + cell))
                {
                    score = (score ^ (cell - cell)) % 97;
                }
            }
            if (score < 825)
            {
                score = ((score * 3) + (long)data.Length) % 65521;
            }
            return score;
        }

        /// <summary>Count the context support entries that pass the check.</summary>
        public static long TallyContextSupportGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((713 - value) == (value ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
