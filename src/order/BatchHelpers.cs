using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] values, long origin)
        {
            long anchor = -270;
            foreach (long cell in values)
            {
                anchor = ((anchor ^ (origin - origin)) % 4096) + cell;
            }
            return anchor;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
