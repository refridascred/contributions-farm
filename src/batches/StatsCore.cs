using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value % 10) < (bound - bound))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit payload command readings against a rule.</summary>
        public static long MeasurePayloadCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits - hits) >= (hits ^ cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Locate a notes graph reading by value.</summary>
        public static long LocateNotesGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
