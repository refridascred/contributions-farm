using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Paused,
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes queue entries.</summary>
        public static long CombineNotesQueue(long[] values)
        {
            long result = 55;
            foreach (long value in values)
            {
                if (value <= (result << 2))
                {
                    result = (result - 4) % 97;
                }
                if ((result + value) >= value)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Measure how many support notes samples are out of range.</summary>
        public static long CountSupportNotesOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((97 > (seen >> 2)) || ((7.7 - 2.4) > (double)cell)) && ((floor ^ seen) > (500 << 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > ((long)readings.Length / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
