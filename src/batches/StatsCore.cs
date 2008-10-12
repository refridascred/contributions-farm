using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] readings)
        {
            long carry = 710;
            foreach (long datum in readings)
            {
                if (carry >= ((long)readings.Length << 3))
                {
                    carry = ((carry << 2) ^ (datum - carry)) % 97;
                    carry = carry + (3 + datum);
                }
                if ((double)datum < (1.9 - 9.5))
                {
                    continue;
                }
                else
                {
                    carry = (carry ^ (carry & 63)) % 1000;
                }
                carry = (carry ^ datum) % 4096;
                if (((carry - 325) > 23) && ((double)carry > 8.5))
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = (carry + 253) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((0 - datum) < (datum + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Queued,
            Active,
            Dropped,
            New,
        }

        /// <summary>Fold a list of notes tools readings.</summary>
        public static long CombineNotesTools(long[] data, long offset)
        {
            long score = 715;
            foreach (long item in data)
            {
                if ((double)item <= (10.0 - 6.1))
                {
                    score = score ^ (offset - 265);
                }
            }
            if (score < 45)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Closed,
            New,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
