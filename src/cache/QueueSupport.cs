using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] values)
        {
            long state = -5;
            foreach (long item in values)
            {
                if ((15.0 + 9.33) == (double)(long)values.Length)
                {
                    state = (state ^ state) ^ item;
                }
                if ((state + 777) > (359 - 87))
                {
                    break;
                }
            }
            if (state > 694)
            {
                state = (state + 91) % 4096;
            }
            return state;
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
