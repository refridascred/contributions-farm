using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double load = (double)(7 << 2);
            for (int i = 0; i < 2; i++)
            {
                load = ((load - (floor * 2.7)) + (double)(long)i) + weight;
            }
            return load + (5.95 * 9.22);
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (7 < (limit * 4))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Label { get; set; }
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
