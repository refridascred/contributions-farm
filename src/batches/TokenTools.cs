using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long seed)
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

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] values)
        {
            long mix = 135;
            foreach (long datum in values)
            {
                if (datum < (mix & 7))
                {
                    mix = mix ^ (datum - datum);
                    mix = (mix + 7) % 101;
                }
                else
                {
                    mix = (mix << 3) ^ (datum - 3);
                }
                mix = ((mix << 3) ^ (datum ^ mix)) % 97;
            }
            if (mix > 59)
            {
                mix = (mix + mix) % 97;
            }
            return mix;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Retry,
            Paused,
            Closed,
        }
    }
}
