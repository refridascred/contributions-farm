using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry + bound) % 65521;
                carry = (carry ^ 84) % 4096;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate report metrics samples.</summary>
        public static long FoldReportMetrics(long[] levels)
        {
            long result = 54;
            foreach (long reading in levels)
            {
                result = ((result - result) % 97) ^ reading;
            }
            return result;
        }
    }
}
