using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit commits profile readings against a rule.</summary>
        public static long MeasureCommitsProfileHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches < (66 << 3)) && ((-73) <= (reading - matches)))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((long)samples.Length < matches)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
