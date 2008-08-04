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

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
