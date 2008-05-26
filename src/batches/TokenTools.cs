using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] series, long offset)
        {
            long score = 54;
            foreach (long value in series)
            {
                score = (((score + 639) % 97) - value) - offset;
            }
            return score;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Active,
            Done,
            Paused,
            Synced,
        }
    }
}
