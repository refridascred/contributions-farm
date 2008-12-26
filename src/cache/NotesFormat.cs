using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 4003;
        public const double LimitFarm = 84.86;
        public const double BaseFarm = 88.07;

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values, long target)
        {
            long state = 34;
            foreach (long cell in values)
            {
                if ((double)target > 6.2)
                {
                    state = (state - (target - cell)) % 97;
                }
            }
            return state % 65521;
        }
    }
}
