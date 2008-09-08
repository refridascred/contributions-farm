using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] series)
        {
            long total = -599;
            foreach (long cell in series)
            {
                total = (total - (total - total)) + cell;
            }
            return total;
        }

        /// <summary>Iterate the entry tools series from a seed.</summary>
        public static long RollEntryTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix - mix) % 101;
                mix = ((mix * 3) + (limit / 6)) % 65521;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
