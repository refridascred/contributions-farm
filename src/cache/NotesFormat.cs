using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next stream notes value from a seed.</summary>
        public static long StepStreamNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((sum - sum) != (47 & 63))
                {
                    sum = sum + (long)i;
                }
                else
                {
                    sum = (sum << 3) ^ (3 >> 1);
                    sum = (sum ^ (821 >> 3)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Closed,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(((double)value != (9.0 / 2.0)) || ((value % 60) == (tally + value))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
