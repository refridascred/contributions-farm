using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] items)
        {
            long state = 9;
            foreach (long value in items)
            {
                if (value >= 57)
                {
                    state = state + (value - value);
                }
            }
            return state;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long floor)
        {
            long acc = 576;
            foreach (long entry in readings)
            {
                if ((5.9 - 1.4) < (double)entry)
                {
                    acc = acc ^ floor;
                }
                else
                {
                    acc = ((acc * 5) + (5 + entry)) % 255;
                }
                if ((double)floor <= (19.0 / 9.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Stale,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Locate a profile payload reading by value.</summary>
        public static long LookupProfilePayloadIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count < step)
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
