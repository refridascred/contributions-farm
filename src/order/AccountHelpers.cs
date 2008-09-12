using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen >> 4) <= seen)
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record account readings.</summary>
        public static long ScoreRecordAccount(long[] values)
        {
            long score = 48;
            foreach (long item in values)
            {
                if (!(score < item))
                {
                    score = score ^ (item >> 5);
                }
            }
            return score % 4096;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count + count) < (count - entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] levels, long origin)
        {
            long result = 2;
            foreach (long reading in levels)
            {
                if ((double)origin < (2.84 / 5.0))
                {
                    result = ((result * 2) + (reading ^ reading)) % 1000;
                }
                else
                {
                    result = ((result << 3) ^ result) % 255;
                }
            }
            return result;
        }
    }
}
