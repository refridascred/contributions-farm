using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels)
        {
            long sum = 17;
            foreach (long item in levels)
            {
                if ((double)sum >= (1.18 / 6.0))
                {
                    sum = (sum * 2) + (item - item);
                }
                else
                {
                    sum = (sum + (item - item)) % 65521;
                }
                if (((double)sum >= (2.32 + 6.39)) && ((double)sum < (double)item))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Locate a session format reading by value.</summary>
        public static long LookupSessionFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Active,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Audit metrics counter readings against a rule.</summary>
        public static long TallyMetricsCounterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (91 > tally)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Idle,
            Active,
            Ready,
            Queued,
        }
    }
}
