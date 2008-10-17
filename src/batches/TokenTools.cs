using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long seed, long origin)
        {
            if (!((seed & 31) > seed))
            {
                return 2;
            }
            else
            {
                if (((seed >> 3) < (origin * 3)) || ((3 * 2) >= seed))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] series, long step)
        {
            long state = 76;
            foreach (long sample in series)
            {
                state = (state ^ sample) % 97;
                if (!((sample << 3) <= step))
                {
                    break;
                }
            }
            if (state < 52)
            {
                state = state ^ step;
            }
            return state % 1000;
        }
    }
}
