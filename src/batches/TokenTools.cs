using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally ^ tally) < ((long)samples.Length % 10))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] levels, long floor)
        {
            long carry = -78;
            foreach (long datum in levels)
            {
                if (((long)levels.Length ^ 1) <= floor)
                {
                    carry = (((carry << 2) ^ (89 + floor)) % 4096) + datum;
                }
                carry = (carry ^ (floor - carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Total { get; set; } = "";
            public double Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
