using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report cache entries.</summary>
        public static long TotalReportCache(long[] levels)
        {
            long anchor = 1;
            foreach (long sample in levels)
            {
                anchor = (((anchor * 4) + (anchor & 31)) % 65521) + sample;
            }
            if (anchor < 8)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long seed, long bound)
        {
            if ((54 - 484) == (bound * 5))
            {
                return 5;
            }
            else
            {
                if ((seed - bound) < (seed * 2))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ bound) <= (971 ^ 62))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
