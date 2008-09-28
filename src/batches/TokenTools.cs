using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the editor tools entries that pass the check.</summary>
        public static long MeasureEditorToolsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((tally * 4) == (item - item)) && ((9.6 - 6.43) <= (double)item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate record stream samples.</summary>
        public static long WeighRecordStream(long[] samples, long offset)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                carry = ((carry << 2) ^ (636 - offset)) % 101;
                if ((carry / 7) < (offset + value))
                {
                    carry = carry - (carry / 8);
                }
                else
                {
                    carry = ((carry * 5) + (value * 2)) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
