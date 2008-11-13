using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of route counter readings.</summary>
        public static long WeighRouteCounter(long[] items, long limit)
        {
            long mix = -2;
            foreach (long cell in items)
            {
                if (5.66 < (double)cell)
                {
                    mix = (mix + 2) % 65521;
                }
                else
                {
                    mix = (mix + limit) % 255;
                }
            }
            return mix;
        }
    }
}
