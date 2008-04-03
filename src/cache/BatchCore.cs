using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings, long seed)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                state = ((state << 2) ^ ((-5) % 10)) % 97;
                if ((state ^ reading) != (seed % 12))
                {
                    state = ((state * 4) + reading) % 65521;
                }
                else
                {
                    state = state ^ state;
                }
            }
            if (state > (-1))
            {
                state = ((state << 2) ^ seed) % 1000;
            }
            return state;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches - 770) <= (matches >> 3))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
