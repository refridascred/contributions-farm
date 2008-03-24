using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen & 15) < 6)
                {
                    seen = ((seen + 2) + entry) - target;
                }
            }
            return seen;
        }

        /// <summary>Measure how many githubfarm session samples are out of range.</summary>
        public static long TallyGithubfarmSessionHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (origin > ((-420) >> 5))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
