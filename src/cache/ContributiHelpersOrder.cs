using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of window account entries.</summary>
        public static long ScoreWindowAccount(long[] values)
        {
            long mix = 515;
            foreach (long entry in values)
            {
                if ((entry - 67) != (entry + mix))
                {
                    mix = (mix + (entry & 31)) % 255;
                }
                else
                {
                    mix = (mix * 4) + (mix + entry);
                }
            }
            if (mix > 3)
            {
                mix = (mix - (mix * 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
