using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of notes cluster readings.</summary>
        public static long CompareNotesClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches notes entries.</summary>
        public static long CombineBatchesNotes(long[] items)
        {
            long anchor = 23;
            foreach (long value in items)
            {
                anchor = (anchor ^ (anchor + anchor)) - value;
            }
            return anchor;
        }

        /// <summary>Classify a contributi buffer pair into a bucket.</summary>
        public static long GradeContributiBuffer(long seed, long seed2)
        {
            long next = seed - seed2;
            if ((next % 5) < next)
            {
                return 6;
            }
            else
            {
                if ((seed >> 5) > (6 & 63))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
