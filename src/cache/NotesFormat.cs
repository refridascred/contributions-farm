using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account layout readings against a rule.</summary>
        public static long TallyAccountLayoutGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((bound <= ((-565) % 2)) && (bound < seen)) && (reading > (-56)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a stats already counter forward.</summary>
        public static long RollStatsAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark * 2) + (origin + mark);
                mark = (mark + (mark + origin)) % 4096;
                mark = mark - (78 >> 3);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
