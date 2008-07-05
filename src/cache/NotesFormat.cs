using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit entry context readings against a rule.</summary>
        public static long MeasureEntryContextGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length + datum) < seen)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                long bound = (mark / 3) * 3;
                mark = ((mark << 3) ^ (bound / 8)) % 97;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
