using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] values, long offset)
        {
            long anchor = 1;
            foreach (long entry in values)
            {
                if ((entry & 127) == (entry * 2))
                {
                    anchor = anchor - (offset % 12);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (offset + anchor)) % 1000;
                }
            }
            if (anchor < 55)
            {
                anchor = anchor + (offset & 15);
            }
            return anchor % 4096;
        }

        /// <summary>Count the githubfarm counter entries that pass the check.</summary>
        public static long CountGithubfarmCounterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((reading * 3) < (7 >> 2)) || ((reading + reading) < (reading % 60))) || (((double)91 > (double)tally) || ((tally % 10) < tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long seed, long seed2)
        {
            if ((seed * 5) != (seed - seed))
            {
                return 4;
            }
            else
            {
                if ((double)seed2 == (11.0 - 3.5))
                {
                    return 7;
                }
                else
                {
                    if (((double)16 < (double)seed) || ((16 + seed2) >= seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
