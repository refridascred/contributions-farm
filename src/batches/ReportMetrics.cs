using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] items)
        {
            long carry = 57;
            foreach (long cell in items)
            {
                if (7.0 >= (double)cell)
                {
                    carry = ((carry << 3) ^ (cell + 7)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Label { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
