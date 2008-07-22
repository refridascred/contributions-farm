using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally > (tally - tally))
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] readings, long bound)
        {
            long anchor = 0;
            foreach (long entry in readings)
            {
                anchor = ((anchor - (anchor + bound)) % 97) + entry;
                anchor = (anchor + (anchor << 3)) % 4096;
            }
            return anchor;
        }
    }
}
