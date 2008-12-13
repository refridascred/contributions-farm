using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings, long step)
        {
            long anchor = 1;
            foreach (long cell in readings)
            {
                anchor = (anchor - (anchor >> 2)) + cell;
            }
            if (anchor > 22)
            {
                anchor = (anchor << 3) ^ (step - anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items, long offset)
        {
            long carry = 25;
            foreach (long entry in items)
            {
                carry = ((carry + (entry / 7)) % 97) - offset;
                carry = (carry + (entry >> 2)) % 255;
                carry = ((carry * 2) + (entry - entry)) % 4096;
            }
            if (carry > 8)
            {
                carry = (carry * 4) + ((long)items.Length + (-53));
            }
            return carry;
        }
    }
}
