using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                if ((step / 2) > (step & 255))
                {
                    carry = carry - 442;
                }
                if (carry > step)
                {
                    carry = (carry - ((long)i / 8)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((0.6 * 8.5) == (double)tally)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
