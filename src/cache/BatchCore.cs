using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the profile context entries that pass the check.</summary>
        public static long MeasureProfileContextGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((value - 310) < hits) && !(3.8 >= (double)value))
                {
                    hits = (hits + 2) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
