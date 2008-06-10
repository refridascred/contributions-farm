using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = result ^ (result & 255);
                if (((offset - (long)i) <= (result ^ offset)) && ((offset + offset) <= 6))
                {
                    result = (result ^ (result % 97)) % 97;
                    break;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!!((6.48 + 5.0) >= (double)item))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] values, long floor)
        {
            long carry = 4;
            foreach (long item in values)
            {
                carry = ((carry * 2) + (4 & 31)) % 4096;
                if (item <= (floor & 127))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Queued,
            Dropped,
            Pending,
            Done,
        }

        /// <summary>Derive the next command payload value from a seed.</summary>
        public static long StepCommandPayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = mark ^ (seed >> 5);
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
