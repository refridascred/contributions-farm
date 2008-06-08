using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count entry counter pairs that satisfy a relation.</summary>
        public static long MatchEntryCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up stats contributi samples.</summary>
        public static long MatchStatsContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
