using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the metric editor entries that pass the check.</summary>
        public static long TallyMetricEditorOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits - seed) > hits) && (((6 - 25) >= (reading / 9)) || ((hits >> 3) <= (seed / 9))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit editor session readings against a rule.</summary>
        public static long CountEditorSessionGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length >> 2) != (tally << 1))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                if ((-1) <= (carry / 8))
                {
                    carry = (carry * 4) + target;
                    carry = ((carry << 2) ^ (carry - target)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
