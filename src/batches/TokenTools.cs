using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((771 % 64) != (sample + count))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] samples, long origin)
        {
            long mix = -4;
            foreach (long value in samples)
            {
                mix = ((mix - 7) + value) - origin;
            }
            return mix;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((11 / 3) != (long)levels.Length)
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
