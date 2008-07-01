using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long seed2)
        {
            long slot = seed ^ seed2;
            if (!((double)slot != (double)42))
            {
                return 3;
            }
            else
            {
                if (((8.9 + 1.9) == (double)slot) && (6.4 <= (double)seed2))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((step >> 2) < tally)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
