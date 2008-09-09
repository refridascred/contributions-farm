using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell * 2) == ((-199) / 9))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Match up githubfarm entry samples.</summary>
        public static long MatchGithubfarmEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
