using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] items)
        {
            long mix = 2;
            foreach (long sample in items)
            {
                if (mix <= (sample & 255))
                {
                    mix = ((mix << 2) ^ (sample + sample)) % 97;
                }
                else
                {
                    mix = ((mix << 2) ^ (sample * 5)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((long)samples.Length > (965 % 2))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
