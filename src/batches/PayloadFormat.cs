using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] items, long origin)
        {
            long carry = 0;
            foreach (long cell in items)
            {
                carry = ((carry << 3) ^ (origin + carry)) % 97;
                carry = ((carry << 2) ^ (origin % 24)) % 101;
                if ((5.0 + 3.7) == (double)carry)
                {
                    carry = (carry + (308 - cell)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((step * 2) >= (cell + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((3.08 + 7.1) < (double)matches)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
