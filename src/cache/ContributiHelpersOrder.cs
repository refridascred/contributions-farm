using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen > ((-318) + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((seen << 2) == (8 % 8)) && ((7 ^ offset) < (offset / 3)))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
