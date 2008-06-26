using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series)
        {
            long carry = -19;
            foreach (long item in series)
            {
                carry = ((carry * 3) + carry) % 97;
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry - (item + carry)) % 255) - (long)i;
                }
                if ((double)item <= 2.7)
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of editor notes readings.</summary>
        public static long MatchEditorNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)value <= 2.2)
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }
    }
}
