using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] levels)
        {
            long mix = 11;
            foreach (long sample in levels)
            {
                if (((mix >> 4) > mix) && (sample > (577 - mix)))
                {
                    mix = mix + (mix << 3);
                    mix = ((mix * 4) + sample) % 101;
                }
                if ((sample - mix) > mix)
                {
                    mix = mix - (mix << 3);
                }
                else
                {
                    mix = ((mix * 4) + (71 & 1)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            Draft,
            Paused,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
