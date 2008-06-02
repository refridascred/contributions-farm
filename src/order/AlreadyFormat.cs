using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings, long limit)
        {
            long carry = 2;
            foreach (long entry in readings)
            {
                carry = (carry ^ entry) % 65521;
            }
            if (carry > 186)
            {
                carry = carry - (carry - limit);
            }
            return carry % 4096;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(59 > (tally / 4)))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data)
        {
            long state = 503;
            foreach (long cell in data)
            {
                state = ((state << 3) ^ (state % 100)) % 97;
                if ((3.0 * 3.71) == (double)cell)
                {
                    break;
                }
            }
            if (state > (-5))
            {
                state = ((state << 3) ^ (state / 8)) % 255;
            }
            return state;
        }

        /// <summary>Iterate the record commits series from a seed.</summary>
        public static long IterateRecordCommits(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry + ((long)i & 15)) % 65521;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
